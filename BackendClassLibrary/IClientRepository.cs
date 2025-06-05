using DevExpress.XtraGrid;

namespace bakk_project_task
{
    public interface IClientRepository
    {
        Task AddClient(string firstName, string lastName, string email, string address, string phoneNumber, string status);
        Task UpdateClient(int? id, string firstName, string lastName, string email, string address, string phoneNumber, string status);
        Task LoadClient(DataGridView dataGridView);
        Task DeleteClient(int? id);
        void SearchClients(DataGridView dataGridView, string SearchFirstName, string SearchLastName, string SearchAddress, string SearchPhoneNumber, string SearchEmail, string SearchStatus, bool blankEmailflag = false,
            bool blankTelephoneflag = false);
        void SearchClients(GridControl dataGridView, string SearchFirstName,
            string SearchLastName, string SearchAddress, string SearchPhoneNumber,
            string SearchEmail, string? SearchStatus, bool blankEmailflag = false,
            bool blankTelephoneflag = false);
        //Task CreateSubtableEntry(int? id, string TableName);
        //Task ReadSubTableEntry(int? id, string TableName);
        //Task UpdateSubtableEntry(GridControl gridControl, string ColumnName, string TableName, string Entry, int id);
        //Task DeleteSubtableEntry(DataGridView dataGridView, string TableName, int id);
    }
}
