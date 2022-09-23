using Budget.Models;
using Microsoft.EntityFrameworkCore;

namespace Budget.Data
{
    public class BudgetContext: DbContext
    {
        public DbSet<Consumption> Consumptions { get; set; }

        public BudgetContext(DbContextOptions<BudgetContext> options):base(options)
        {

        }
    }
}
