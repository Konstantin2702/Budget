using Budget.Data;
using Budget.Models;

namespace Budget.Services
{
    public class DbService:IDbService
    {
        public async Task AddConsumptionToDb(Consumption consumption, BudgetContext db)
        {         
            await db.Consumptions.AddAsync(consumption);
            await db.SaveChangesAsync();
        }
    }
}
