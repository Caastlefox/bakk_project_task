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
        /*
        Task AddSubtableEntry(int? id, string TableName);
        Task UpdateSubtableEntry(int? id, string TableName);
        Task LoadSubtableEntry(int? id, string TableName);
        Task DeleteSubtableEntry(int? id, string TableName);
        */
    }
}
