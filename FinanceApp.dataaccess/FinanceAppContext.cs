using FinanceApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FinanceApp.dataaccess
{
    public class FinanceAppContext : DbContext
    {
        public FinanceAppContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<General> Generals { get; set; }
        public DbSet<Enterteinment> Enterteinments { get; set; }
    }

}