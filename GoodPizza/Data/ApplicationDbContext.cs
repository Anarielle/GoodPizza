using GoodPizza.Models;
using Microsoft.EntityFrameworkCore;

namespace GoodPizza.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<PizzaOrder> PizzaOrders { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
    }
}
