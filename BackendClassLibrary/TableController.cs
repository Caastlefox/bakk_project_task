using DevExpress.CodeParser;
using DevExpress.Office;
using DevExpress.Utils.DPI;
using DevExpress.Utils.Html.Internal;
using DevExpress.Xpo.DB.Helpers;
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
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace bakk_project_task
{
    public class TableController : ITableController
    {
        private readonly string ConnectionString;
        private List<Entry> ControllerList = [];
        private readonly string TableName;
        private readonly string ParentTable;
        private long ParentId = -1; // Default value for ClientId
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
                    Entry_Id INTEGER,
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
            var entry = new Entry(Name, 'A',-1);
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

        public async Task ReceiveFromDatabase(long Id) 
        {
            this.ParentId = Id;
            ControllerList.Clear();
            using var connection = new SqliteConnection(ConnectionString);
            await connection.OpenAsync();
            var sql = $"SELECT * FROM {TableName} WHERE {TableName}_Id = {ParentId}";
            using var cmd = new SqliteCommand(sql, connection);
            using var reader = await cmd.ExecuteReaderAsync();

            var dt = new DataTable();
            while (await reader.ReadAsync())
            {
                var entry = new Entry
                    (
                    reader.GetString(0),
                    '\0', 
                    reader.GetInt64(1),
                    reader.GetInt64(2) 
                    );
                ControllerList.Add(entry);
            }
        }

        public async Task SendToDataBase(long ParentId)
        {
            try
            {
                if (!ControllerList.Any()) { return; }
                this.ParentId = ParentId;

                using var connection = new SqliteConnection(ConnectionString);
                await connection.OpenAsync();
                var Command = connection.CreateCommand();

                if (ControllerList.Any(e => e.Tag == 'M'))
                {
                    Command.CommandText = @$"UPDATE {TableName}
                                        SET {TableName} = CASE {TableName}_Id ";

                    Command.CommandText += string.Join(",", ControllerList.Where(e => e.Tag == 'M').Select(e => $"WHEN {e.Id} THEN {e.Name}"))
                                              + $"END WHERE {TableName} IN ("
                                              + string.Join(",", ControllerList.Where(e => e.Tag == 'M').Select(e => e.Id)) + ");";

                    Command.CommandText += "(" + string.Join(",", ControllerList.Where(e => e.Tag == 'M').Select(e => e.Id)) + ")";
#if DEBUG
                    MessageBox.Show(Command.CommandText, "Debug Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
#endif
                    await Command.ExecuteNonQueryAsync();
                }

                if (ControllerList.Any(e => e.Tag == 'D'))
                {
                    Command.CommandText = @$"DELETE FROM {TableName} 
                                        WHERE {TableName}_Id IN (";

                    Command.CommandText += string.Join(",", ControllerList.Where(e => e.Tag == 'D').Select(e => e.Id))
                                        + ");";
#if DEBUG
                    MessageBox.Show(Command.CommandText, "Debug Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
#endif
                    await Command.ExecuteNonQueryAsync();
                }

                List<long> InsertedRowIds = [];
                if (ControllerList.Any(e => e.Tag == 'A'))
                {
                    foreach (var item in ControllerList.Where(e => e.Tag == 'A'))
                    {
                        Command.CommandText = @$"INSERT INTO {TableName}
                                        ({TableName},{ParentTable}_Id) VALUES ";
                        Command.CommandText += $"(\'{item.Name}\',{ParentId})";
#if DEBUG
                        MessageBox.Show(Command.CommandText, "Debug Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
#endif     
                        await Command.ExecuteNonQueryAsync();
  
                        Command.CommandText = "SELECT last_insert_rowid();";
                        var lastid = (long?)Command.ExecuteScalar();
                        if (lastid == null)
                        {
                            MessageBox.Show("Failed to retrieve last inserted row ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            continue;
                        }
                        item.Id = lastid.Value;
                    }

                    
                }


                int j = 1;
                for (int i = 0; i < ControllerList.Count; i++)
                {
                    if (ControllerList[i].Tag == 'D')
                    {
                        continue;
                    }
                    ControllerList[i].EntryId = j;
                    j++;
                }

                Command.CommandText = @$"UPDATE {TableName}
                                      SET Entry_Id = CASE ";
                Command.CommandText += string.Join(" ", ControllerList.Where(e => e.Tag != 'D').Select(e => $"WHEN {e.Id} THEN {e.EntryId} "));
                Command.CommandText += @$" END 
                                        WHERE {ParentTable}_Id IN (";
                Command.CommandText += string.Join(",", ControllerList.Where(e => e.Tag != 'D').Select(e => e.Id));
                Command.CommandText += ");";
#if DEBUG
                MessageBox.Show(Command.CommandText, "Debug Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
#endif     
                await Command.ExecuteNonQueryAsync();
            }
            catch (SqliteException ex)
            {
                MessageBox.Show(
                    $"SQLite Error Code: {ex.SqliteErrorCode}\n{ex.Message}",
                    "SQLite Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }
            catch (InvalidOperationException ex)
            {
                // Connection state issues
                MessageBox.Show(
                    $"Invalid operation: {ex.Message}",
                    "Operation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                // All other errors
                MessageBox.Show(
                    $"Unexpected error: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        public void SendToGridControl(GridControl TableGrid)
        {
            TableGrid.DataSource = ControllerList;
            TableGrid.MainView.PopulateColumns();
        }

        public void ClearControllerList()
        {
            ControllerList.Clear();
        }

        [SupportedOSPlatform("windows6.1")]
        public async Task DeleteClient(long? id)
        {
            try
            {
                using var connection = new SqliteConnection(ConfigurationManager.ConnectionStrings["SQLiteConnection"].ConnectionString);
                await connection.OpenAsync();
                var command = connection.CreateCommand();
                command.CommandText = @$"
                DELETE FROM {TableName} WHERE {ParentTable}_Id = $id;
            ";
                command.Parameters.AddWithValue("$id", id);
                await command.ExecuteNonQueryAsync();
            }
            catch (SqliteException ex)
            {
                MessageBox.Show(
                    $"SQLite Error Code: {ex.SqliteErrorCode}\n{ex.Message}",
                    "SQLite Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }
            catch (InvalidOperationException ex)
            {
                // Connection state issues
                MessageBox.Show(
                    $"Invalid operation: {ex.Message}",
                    "Operation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                // All other errors
                MessageBox.Show(
                    $"Unexpected error: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

    }
}