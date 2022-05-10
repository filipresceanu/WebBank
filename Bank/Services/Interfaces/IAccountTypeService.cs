using Bank.Models;
using System.Linq.Expressions;

namespace Bank.Services.Interfaces
{
    public interface IAccountTypeService
    {
        List<AccountType> GetAccountType();
        List<AccountType> GetAccountTypeByCondition(Expression<Func<AccountType, bool>> expression);
        void AddAccountType(AccountType administrator);
        void UpdateAccountType(AccountType administrator);
        void DeleteAccountType(AccountType administrator);

        void Save();
    }
}
