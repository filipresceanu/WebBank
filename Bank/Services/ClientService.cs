using Bank.Models;
using Bank.Repositories.Interfaces;
using Bank.Services.Interfaces;
using System.Linq.Expressions;

namespace Bank.Services
{
    public class ClientService:IClientService
    {
        private IRepositoryWrapper _repositoryWrapper;
        public ClientService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }
        public void AddClient(Client client)
        {
            _repositoryWrapper.ClientRepository.Create(client);
        }

        public void DeleteClient(Client client)
        {
            _repositoryWrapper.ClientRepository.Delete(client);
        }

        public List<Client> GetClient()
        {
            return _repositoryWrapper.ClientRepository.FindAll().ToList();
        }

        public List<Client> GetClientByCondition(Expression<Func<Client, bool>> expression)
        {
            return _repositoryWrapper.ClientRepository.FindByCondition(expression).ToList();
        }

        public void UpdateClient(Client client)
        {
            _repositoryWrapper.ClientRepository.Update(client);
        }
        public void Save()
        {
            _repositoryWrapper.Save();
        }
    }
}
