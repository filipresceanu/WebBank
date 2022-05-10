using Bank.Models;
using System.Linq.Expressions;

namespace Bank.Services.Interfaces
{
    public interface ITranzactionService
    {
        List<Tranzaction> GetTranzaction();
        List<Tranzaction> GetTranzactionByCondition(Expression<Func<Tranzaction, bool>> expression);
        void AddTranzaction(Tranzaction tranzaction);
        void UpdateTranzaction(Tranzaction tranzaction);
        void DeleteTranzaction(Tranzaction tranzaction);

        void Save();
    }
}
