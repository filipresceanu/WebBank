using Bank.Models;
using System.Linq.Expressions;

namespace Bank.Services.Interfaces
{
    public interface IClientService
    {
        List<Client> GetClient();
        List<Client> GetClientByCondition(Expression<Func<Client, bool>> expression);
        void AddClient(Client client);
        void UpdateClient(Client client);
        void DeleteClient(Client client);

        void Save();
    }
}
