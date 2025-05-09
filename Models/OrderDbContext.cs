using Microsoft.EntityFrameworkCore;

namespace OP.Models
{
    public class OrderDbContext : DbContext
    {

        public DbSet<Orders> Order { get; set; }
       public OrderDbContext(DbContextOptions<OrderDbContext>options) : base(options) { 
        
        }

    }

  
}
