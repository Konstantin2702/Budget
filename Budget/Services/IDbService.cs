using Budget.Data;
using Budget.Models;

namespace Budget.Services
{
    public interface IDbService
    {
        public Task AddConsumptionToDb(Consumption consumption, BudgetContext db);
    }
}
