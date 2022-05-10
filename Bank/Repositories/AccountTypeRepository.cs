using Bank.Context;
using Bank.Models;
using Bank.Repositories.Interfaces;

namespace Bank.Repositories
{
    public class AccountTypeRepository:RepositoryBase<AccountType>,IAccountTypeRepository
    {
        public AccountTypeRepository(MVCContext dbContext):base(dbContext)
        {

        }
    }
}
