using Bank.Models;
using System.Linq.Expressions;

namespace Bank.Services.Interfaces
{
    public interface IBankAccountService
    {
        List<BankAccount> GetBankAccount();
        List<BankAccount> GetBankAccountyCondition(Expression<Func<BankAccount, bool>> expression);
        void AddBankAccount(BankAccount bankAccount);
        void UpdateBankAccount(BankAccount bankAccount);
        void DeleteBankAccount(BankAccount bankAccount);

        void Save();
    }
}
