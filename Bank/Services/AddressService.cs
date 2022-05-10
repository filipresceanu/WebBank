using Bank.Models;
using Bank.Repositories.Interfaces;
using Bank.Services.Interfaces;
using System.Linq.Expressions;

namespace Bank.Services
{
    public class AddressService:IAddressService
    {
        private IRepositoryWrapper _repositoryWrapper;
        public AddressService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }
        public void AddAddress(Address address)
        {
            _repositoryWrapper.AddressRepository.Create(address);
        }

        public void DeleteAddress(Address address)
        {
            _repositoryWrapper.AddressRepository.Delete(address);
        }

        public List<Address> GetAddress()
        {
            return _repositoryWrapper.AddressRepository.FindAll().ToList();
        }

        public List<Address> GetAddressByCondition(Expression<Func<Address, bool>> expression)
        {
            return _repositoryWrapper.AddressRepository.FindByCondition(expression).ToList();
        }

        public void UpdateAddress(Address address)
        {
            _repositoryWrapper.AddressRepository.Update(address);
        }
        public void Save()
        {
            _repositoryWrapper.Save();
        }
    }
}
