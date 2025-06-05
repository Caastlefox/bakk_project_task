using DevExpress.CodeParser;
using DevExpress.Utils.DPI;
using DevExpress.Utils.Html.Internal;
using DevExpress.XtraBars.Customization;
using DevExpress.XtraGrid;
using DevExpress.XtraPrinting.Native;
using DevExpress.XtraRichEdit.Import.Html;
using DevExpress.XtraRichEdit.Import.OpenXml;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace bakk_project_task
{
    public interface ITableController
    {

    }
    public class Entry
    {
        public string Name;
        public char Tag;
        public int Id;
        public string EntryName => Name;
        public Entry(string name, char tag, int id = -1)
        {
            this.Id = id;
            this.Name = name;
            this.Tag = tag;
        }

    }
    public class TableController : ITableController
    {
        private readonly string ConnectionString;
        private List<Entry> ControllerList = new List<Entry>();
        private string TableName;
        private string ParentTable;
        private int ClientId = -1; // Default value for ClientId
        public TableController(string ParentTable, string TableName)
        {
            var conn = ConfigurationManager.ConnectionStrings["SQLiteConnection"]?.ConnectionString;
            if (string.IsNullOrEmpty(conn))
            {
                throw new InvalidOperationException("Connection string 'SQLiteConnection' is not configured.");
            }
            this.ConnectionString = conn;
            this.TableName = TableName;
            this.ParentTable = ParentTable;
            using var connection = new SqliteConnection(ConnectionString);
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = @$"
                CREATE TABLE IF NOT EXISTS {TableName}(
                    {TableName}_Id INTEGER PRIMARY KEY AUTOINCREMENT,                   
                    {TableName} TEXT,
                    {ParentTable}_Id INTEGER,
                    FOREIGN KEY ({ParentTable}_Id) REFERENCES {ParentTable}({ParentTable}_Id)
                );";
            command.ExecuteNonQuery();
        }
        public void AddElement(string Name)
        {
#if  DEBUG 
            if (string.IsNullOrEmpty(Name) )
            {
                throw new ArgumentException("Entry cannot be null or empty.");
            }
#endif
            if (ControllerList.Any(e => e.Name == Name))
            {
                MessageBox.Show("Entry already exists in the list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Entry entry = new Entry(Name, 'A');
            ControllerList.Add(entry);
        }

        public void RemoveElement(string Name)
        {
#if DEBUG
            //Sanity Check
            if (string.IsNullOrEmpty(Name))
            {
                MessageBox.Show($"Entry \"{Name}\" not found in the list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
#endif

            Entry? entrytoedit = ControllerList.FirstOrDefault(t => t.Name == Name);
            if (entrytoedit == null)
            {
                MessageBox.Show($"Entry \"{Name}\" not found in the list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            switch (entrytoedit.Tag)
            {
                case '\0':
                    entrytoedit.Tag = 'D';
                    return;
                case 'M':
                    entrytoedit.Tag = 'D';
                    return;
                case 'A':
                    ControllerList.Remove(entrytoedit);
                    return;
#if DEBUG
                default:
                    throw new ArgumentException("Tag can only be 'M', 'A' or '\\0' here");
#endif
            }
        }

        public void EditElement(string OldEntryName, string NewEntryName)
        {
            Entry? entrytoedit = ControllerList.FirstOrDefault(t => t.Name == OldEntryName);
            if (entrytoedit == null)
            {
                MessageBox.Show("Entry not found in the list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            switch (entrytoedit.Tag)
            {
                case '\0':
                    entrytoedit.Name = NewEntryName;
                    entrytoedit.Tag = 'M';
                    return;
                case 'M':
                    entrytoedit.Name = NewEntryName;
                    return;
                case 'A':
                    entrytoedit.Name = NewEntryName;
                    return;
#if DEBUG
                default:
                    throw new ArgumentException("Tag can only be 'M', 'A' or '\\0' here");
#endif
            }
        }

        public async Task ReceiveFromDatabase(int Id) 
        {
            this.ClientId = Id;
            ControllerList.Clear();
            using var connection = new SqliteConnection(ConnectionString);
            await connection.OpenAsync();
            var sql = $"SELECT * FROM {TableName} WHERE {TableName}_Id = {ClientId}";
            using var cmd = new SqliteCommand(sql, connection);
            using var reader = await cmd.ExecuteReaderAsync();

            var dt = new DataTable();
            while (await reader.ReadAsync())
            {
                var entry = new Entry
                    (
                    reader.GetString(reader.GetOrdinal(TableName)),
                    '\0', 
                    reader.GetInt32(reader.GetOrdinal($"{TableName}_Id"))
                    );
                ControllerList.Add(entry);
            }
        }

        public async Task SendToDataBase()
        {
            using var connection = new SqliteConnection(ConnectionString);
            await connection.OpenAsync();

            var ModifyCommand = connection.CreateCommand();
            var DeleteCommand = connection.CreateCommand();
            var AddCommand = connection.CreateCommand();
#if DEBUG
            MessageBox.Show("REMINDER THEY HAVE TO HAVE ALL TAGS, DELETE WHEN TEST COMPLETE", "Debug Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
#endif
            if (ControllerList.Any(e => e.Tag == 'M'))
            {
                ModifyCommand.CommandText = @$"UPDATE {TableName}
                                        SET {TableName} = CASE {TableName}_Id ";

                ModifyCommand.CommandText += string.Join(",", ControllerList.Where(e => e.Tag == 'M').Select(e => $"WHEN {e.Id} THEN {e.Name}"))
                                          + $"END WHERE {TableName} IN ("
                                          + string.Join(",", ControllerList.Where(e => e.Tag == 'M').Select(e => e.Id)) + ");";

                ModifyCommand.CommandText += "(" + string.Join(",", ControllerList.Where(e => e.Tag == 'M').Select(e => e.Id)) + ")";
            }

            if (ControllerList.Any(e => e.Tag == 'D'))
            {
                DeleteCommand.CommandText = @$"DELETE FROM {TableName} 
                                        WHERE {TableName}_Id IN (";

                DeleteCommand.CommandText += string.Join(",", ControllerList.Where(e => e.Tag == 'D').Select(e => e.Id)) + ");";
            }
            
            if (ControllerList.Any(e => e.Tag == 'A'))
            {
                AddCommand.CommandText = @$"INSERT INTO {TableName}
                                        ({TableName},{ParentTable}_Id) VALUES (";
                AddCommand.CommandText += string.Join("), (", ControllerList.Where(e => e.Tag == 'A').Select(e => $"('{e.Name}', {e.Id})")) + ";";
            }
                
#if DEBUG
            MessageBox.Show(ModifyCommand.CommandText, "Debug Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show(DeleteCommand.CommandText, "Debug Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show(AddCommand.CommandText   , "Debug Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
#endif
            await ModifyCommand.ExecuteNonQueryAsync();
            await DeleteCommand.ExecuteNonQueryAsync();
            await AddCommand.ExecuteNonQueryAsync();
        }

        public void SendToGridControl(GridControl TableGrid)
        {
            TableGrid.DataSource = ControllerList;
            TableGrid.MainView.PopulateColumns();
        }

    }
}