namespace bakk_project_task
{
    public interface IClientRepository
    {
        void AddClient(string firstName, string lastName, string email, string address, string phoneNumber, string status);
        void UpdateClient(int? id, string firstName, string lastName, string email, string address, string phoneNumber, string status);
        void LoadClient(DataGridView dataGridView);
        void DeleteClient(int? id);
        //DataTable GetAllClients();
        //DataTable SearchClients(string? firstName = null, string? lastName = null, string? address = null, string? phoneNumber = null, string? email = null, string? status = null);
    }
}
