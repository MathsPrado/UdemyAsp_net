using Microsoft.EntityFrameworkCore;

namespace SalesMVC.Models
{
    public class SalesMVCContext : DbContext
    {
        public SalesMVCContext (DbContextOptions<SalesMVCContext> options)
            : base(options)
        {
        }

        public DbSet<SalesMVC.Models.Department> Department { get; set; }
    }
}
