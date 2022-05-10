using Bank.Models;
using Bank.Repositories.Interfaces;
using Bank.Services.Interfaces;
using System.Linq.Expressions;

namespace Bank.Services
{
    public class TranzactionService:ITranzactionService
    {
        private IRepositoryWrapper _repositoryWrapper;
        public TranzactionService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }
        public void AddTranzaction(Tranzaction tranzaction)
        {
            _repositoryWrapper.TranzactionRepository.Create(tranzaction);
        }

        public void DeleteTranzaction(Tranzaction tranzaction)
        {
            _repositoryWrapper.TranzactionRepository.Delete(tranzaction);
        }

        public List<Tranzaction> GetTranzaction()
        {
            return _repositoryWrapper.TranzactionRepository.FindAll().ToList();
        }

        public List<Tranzaction> GetTranzactionByCondition(Expression<Func<Tranzaction, bool>> expression)
        {
            return _repositoryWrapper.TranzactionRepository.FindByCondition(expression).ToList();
        }

        public void UpdateTranzaction(Tranzaction tranzaction)
        {
            _repositoryWrapper.TranzactionRepository.Update(tranzaction);
        }
        public void Save()
        {
            _repositoryWrapper.Save();
        }
    }
}
