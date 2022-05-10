using Microsoft.EntityFrameworkCore;
using Bank.Models;
namespace Bank.Context
{
    public class MVCContext:DbContext
    {
        public MVCContext(DbContextOptions<MVCContext> options) : base(options)
        {

        }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<AccountType> TypeAccounts { get; set; }
        public DbSet<Tranzaction> Tranzactions { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<BankAccount> BankAccounts { get; set; }
        public DbSet<Administrator> Administrators { get; set; }
    }
}
