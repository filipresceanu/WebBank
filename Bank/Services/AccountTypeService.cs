using Bank.Models;
using Bank.Repositories.Interfaces;
using Bank.Services.Interfaces;
using System.Linq.Expressions;

namespace Bank.Services
{
    public class AccountTypeService:IAccountTypeService
    {
        private IRepositoryWrapper _repositoryWrapper;
        public AccountTypeService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }
        public void AddAccountType(AccountType accountType)
        {
            _repositoryWrapper.AccountTypeRepository.Create(accountType);
        }

        public void DeleteAccountType(AccountType accountType)
        {
            _repositoryWrapper.AccountTypeRepository.Delete(accountType);
        }

        public List<AccountType> GetAccountType()
        {
            return _repositoryWrapper.AccountTypeRepository.FindAll().ToList();
        }

        public List<AccountType> GetAccountTypeByCondition(Expression<Func<AccountType, bool>> expression)
        {
            return _repositoryWrapper.AccountTypeRepository.FindByCondition(expression).ToList();
        }

        public void UpdateAccountType(AccountType accountType)
        {
            _repositoryWrapper.AccountTypeRepository.Update(accountType);
        }
        public void Save()
        {
            _repositoryWrapper.Save();
        }
    }
}
