using DevExpress.XtraGrid;

namespace bakk_project_task
{
    public interface IClientRepository
    {
        Task<long> AddClient(string firstName, string lastName, string address, string status);
        Task UpdateClient(long? id, string firstName, string lastName, string address, string status);
        Task<List<Client>> LoadClient();
        Task DeleteClient(long? id);
        Task<List<Client>> SearchClients( string SearchFirstName,
            string SearchLastName, string SearchAddress, string SearchPhoneNumber,
            string SearchEmail, string? SearchStatus, bool blankEmailflag = false,
            bool blankTelephoneflag = false);
    }
}
