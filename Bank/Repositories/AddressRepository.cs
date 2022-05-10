using Bank.Context;
using Bank.Models;
using Bank.Repositories.Interfaces;

namespace Bank.Repositories
{
    public class AddressRepository:RepositoryBase<Address>,IAddressRepository
    {
        public AddressRepository(MVCContext dbContext):base(dbContext)
        {

        }
    }
}
