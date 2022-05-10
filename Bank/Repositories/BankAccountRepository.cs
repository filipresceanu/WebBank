using Bank.Context;
using Bank.Models;
using Bank.Repositories.Interfaces;

namespace Bank.Repositories
{
    public class BankAccountRepository:RepositoryBase<BankAccount>,IBankAccountRepository
    {
        public BankAccountRepository(MVCContext dbContext):base(dbContext)
        {

        }
    }
}
