using DevExpress.XtraBars.Customization;
using DevExpress.XtraGrid;
using DevExpress.XtraRichEdit.Import.Html;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bakk_project_task
{
    public interface ITableController
    {

    }
    public struct Entry
    {
        public string Name;
        public char Tag;
        public int Id;
        public Entry(string name, char tag, int id = -1)
        {
            this.Name = name;
            this.Tag = tag;
            this.Id = id;
        }

    }
    public class TableController : ITableController
    {
        private readonly string ConnectionString;
        private List<Entry> ControllerList = new List<Entry>();
        private string TableName;
        private GridControl TableGrid;
        public TableController(string TableName, GridControl TableGrid)
        {
            var conn = ConfigurationManager.ConnectionStrings["SQLiteConnection"]?.ConnectionString;
            if (string.IsNullOrEmpty(conn))
            {
                throw new InvalidOperationException("Connection string 'SQLiteConnection' is not configured.");
            }
            this.ConnectionString = conn;
            this.TableName = TableName;
            this.TableGrid = TableGrid;
        }

        public void AddElement(string Name, char Tag = '\0')
        {
#if  DEBUG 
            if (string.IsNullOrEmpty(Name) )
            {
                throw new ArgumentException("Entry cannot be null or empty.");
            }
            if (Tag != 'D' && Tag != 'M' && Tag != 'A' && Tag != '\0')
            {
                throw new ArgumentException("Tag can only be 'D', 'M', 'A' or '\\0'");
            }
#endif
            if (ControllerList.Any())
            {
                MessageBox.Show("Entry already exists in the list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Entry entry = new Entry(Name, Tag);
            ControllerList.Add(entry);
        }

        public void RemoveElement(string Name)
        {
            Entry entrytoedit = ControllerList.FirstOrDefault(t => t.Name == Name);
            if (entrytoedit.Name == null)
            {
                MessageBox.Show("Entry not found in the list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            Entry entrytoedit = ControllerList.FirstOrDefault(t => t.Name == OldEntryName);
            if (entrytoedit.Name == null)
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
                        entrytoedit = new Entry(NewEntryName, 'A');
                        return;
#if DEBUG
                    default:
                        throw new ArgumentException("Tag can only be 'M', 'A' or '\\0' here");
#endif
                    }

        }

        public void SendToDataBase()
        {
            
        }

        public void SendToGridControl()
        {
            TableGrid.DataSource = ControllerList;
        }
    }
}