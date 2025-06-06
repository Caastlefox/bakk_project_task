using DevExpress.XtraGrid;
using Microsoft.Data.Sqlite;

namespace bakk_project_task
{
    public interface ITableController
    {
        public void AddElement(string Name);
        public void RemoveElement(string Name);
        public void EditElement(string OldEntryName, string NewEntryName);
        public Task ReceiveFromDatabase(long Id);
        public Task SendToDataBase(long ClientId, SqliteTransaction transaction, SqliteConnection connection);
        public void SendToGridControl(GridControl TableGrid);
    }
}