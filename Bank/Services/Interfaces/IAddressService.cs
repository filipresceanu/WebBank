using Bank.Models;
using System.Linq.Expressions;

namespace Bank.Services.Interfaces
{
    public interface IAddressService
    {
        List<Address> GetAddress();
        List<Address> GetAddressByCondition(Expression<Func<Address, bool>> expression);
        void AddAddress(Address administrator);
        void UpdateAddress(Address administrator);
        void DeleteAddress(Address administrator);

        void Save();
    }
}
