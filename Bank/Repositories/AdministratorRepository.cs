using Bank.Context;
using Bank.Models;
using Bank.Repositories.Interfaces;

namespace Bank.Repositories
{
    public class AdministratorRepository:RepositoryBase<Administrator>,IAdministratorRepository
    {
        public AdministratorRepository(MVCContext dbContext):base(dbContext)
        {

        }
    }
}
