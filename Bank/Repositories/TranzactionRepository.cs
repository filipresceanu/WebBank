using Bank.Context;
using Bank.Models;
using Bank.Repositories.Interfaces;

namespace Bank.Repositories
{
    public class TranzactionRepository:RepositoryBase<Tranzaction>, ITranzactionRepository
    {
        public TranzactionRepository(MVCContext dbContext):base(dbContext)
        {

        }
    }
}
