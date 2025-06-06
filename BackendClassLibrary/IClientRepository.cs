using DevExpress.XtraGrid;
using Microsoft.Data.Sqlite;

namespace bakk_project_task
{
    public interface IClientRepository
    {
        Task<long> AddClient(string firstName, string lastName, string address, string status, SqliteTransaction transaction, SqliteConnection connection);
        Task UpdateClient(long? id, string firstName, string lastName, string address, string status,SqliteTransaction transaction, SqliteConnection connection);
        Task LoadClient(DataGridView dataGridView);
        Task DeleteClient(long? id);
        void SearchClients(DataGridView dataGridView, string SearchFirstName, string SearchLastName, string SearchAddress, string SearchPhoneNumber, string SearchEmail, string SearchStatus, bool blankEmailflag = false,
            bool blankTelephoneflag = false);
        void SearchClients(GridControl dataGridView, string SearchFirstName,
            string SearchLastName, string SearchAddress, string SearchPhoneNumber,
            string SearchEmail, string? SearchStatus, bool blankEmailflag = false,
            bool blankTelephoneflag = false);

    }
}
