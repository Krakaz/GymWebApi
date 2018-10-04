using DataLogicLayer.Models;
using Microsoft.EntityFrameworkCore;


namespace DataLogicLayer
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        { }


        public DbSet<PromotionDto> Promotions { get; set; }
        public DbSet<FileDto> Files { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
