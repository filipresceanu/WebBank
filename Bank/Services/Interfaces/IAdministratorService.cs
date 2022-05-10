using Bank.Models;
using System.Linq.Expressions;

namespace Bank.Services.Interfaces
{
    public interface IAdministratorService
    {
        List<Administrator> GetAdministrator();
        List<Administrator> GetAdministratorByCondition(Expression<Func<Administrator, bool>> expression);
        void AddAdministrator(Administrator administrator);
        void UpdateAdministrator(Administrator administrator);
        void DeleteAdministrator(Administrator administrator);

        void Save();
    }
}
