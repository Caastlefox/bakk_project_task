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
        //DataTable GetAllClients();
        //DataTable SearchClients(string? firstName = null, string? lastName = null, string? address = null, string? phoneNumber = null, string? email = null, string? status = null);
    }
}
