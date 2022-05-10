using Bank.Context;
using Bank.Models;
using Bank.Repositories.Interfaces;

namespace Bank.Repositories
{
    public class ClientRepository:RepositoryBase<Client>,IClientRepository
    {
        public ClientRepository(MVCContext dbContext):base(dbContext)
        {

        }
    }
}
