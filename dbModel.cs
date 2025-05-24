using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace bakk_project_task
{
    public class ClientContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }

        public string DbPath { get; }

        public ClientContext()
        {
            var path = "C:\\Users\\Castlefox\\source\\repos\\bakk_project_task\\db";
            DbPath = System.IO.Path.Join(path, "clients.db");
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }
    public class Client
    {
        private int Id { get; set; }
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private string Address { get; set; }
        private string Telephone { get; set; }
        private string Email { get; set; }
        private bool Status { get; set; }
    }
}
