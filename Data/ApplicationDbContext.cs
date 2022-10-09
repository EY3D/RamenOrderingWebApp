using Microsoft.EntityFrameworkCore;
using RamenOrderingWebApp.Models;

namespace RamenOrderingWebApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<RamenOrder> RamenOrders { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
    }
}
