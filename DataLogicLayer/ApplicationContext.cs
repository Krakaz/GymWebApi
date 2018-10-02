using DataLogicLayer.Models;
using Microsoft.EntityFrameworkCore;


namespace DataLogicLayer
{
    public class ApplicationContext : DbContext
    {
        public DbSet<PromotionDTO> Promotions { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
             
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }


    }
}
