using Bank.Models;
using Bank.Repositories.Interfaces;
using Bank.Services.Interfaces;
using System.Linq.Expressions;

namespace Bank.Services
{
    public class BankAccountService:IBankAccountService
    {
        private IRepositoryWrapper _repositoryWrapper;
        public BankAccountService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }
        public void AddBankAccount(BankAccount bankAccount)
        {
            _repositoryWrapper.BankAccountRepository.Create(bankAccount);
        }

        public void DeleteBankAccount(BankAccount bankAccount)
        {
            _repositoryWrapper.BankAccountRepository.Delete(bankAccount);
        }

        public List<BankAccount> GetBankAccount()
        {
            return _repositoryWrapper.BankAccountRepository.FindAll().ToList();
        }

        public List<BankAccount> GetBankAccountyCondition(Expression<Func<BankAccount, bool>> expression)
        {
            return _repositoryWrapper.BankAccountRepository.FindByCondition(expression).ToList();
        }

        public void UpdateBankAccount(BankAccount bankAccount)
        {
            _repositoryWrapper.BankAccountRepository.Update(bankAccount);
        }
        public void Save()
        {
            _repositoryWrapper.Save();
        }
    }
}
