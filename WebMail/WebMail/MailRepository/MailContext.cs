using MailEntities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MailRepositoryInt
{
    internal class MailContext : DbContext
    {
        public DbSet<Mail> Mails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString =
                "Persist Security Info=True;Initial Catalog=EmailManager;Data Source=.; Integrated Security=True;TrustServerCertificate=True;";

            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}