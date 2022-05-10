using Bank.Models;
using Bank.Repositories.Interfaces;
using Bank.Services.Interfaces;
using System.Linq.Expressions;

namespace Bank.Services
{
    public class AdministratorService:IAdministratorService
    {
        private IRepositoryWrapper _repositoryWrapper;
        public AdministratorService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }
        public void AddAdministrator(Administrator administrator)
        {
            _repositoryWrapper.AdministratorRepository.Create(administrator);
        }

        public void DeleteAdministrator(Administrator administrator)
        {
            _repositoryWrapper.AdministratorRepository.Delete(administrator);
        }

        public List<Administrator> GetAdministrator()
        {
            return _repositoryWrapper.AdministratorRepository.FindAll().ToList();
        }

        public List<Administrator> GetAdministratorByCondition(Expression<Func<Administrator, bool>> expression)
        {
            return _repositoryWrapper.AdministratorRepository.FindByCondition(expression).ToList();
        }

        public void UpdateAdministrator(Administrator administrator)
        {
            _repositoryWrapper.AdministratorRepository.Update(administrator);
        }
        public void Save()
        {
            _repositoryWrapper.Save();
        }
    }
}
