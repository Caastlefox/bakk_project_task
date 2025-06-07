using System.ComponentModel;
namespace bakk_project_task
{
    public class Client
    {
        [DisplayName("Id")]
        public required long? Id { get; set; }
        [DisplayName("Imię")]
        public required string? FirstName { get; set; }
        [DisplayName("Nazwisko")]
        public required string? LastName { get; set; }
        [DisplayName("Adres")]
        public required string? Address { get; set; }
        [DisplayName("Email")]
        public required string? Email { get; set; }
        [DisplayName("Numer Telefonu")]
        public required string? PhoneNumber { get; set; }
        [DisplayName("Status")]
        public required string? Status { get; set; }
    }
}
