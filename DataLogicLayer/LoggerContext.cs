using DataLogicLayer.Models;
using Microsoft.EntityFrameworkCore;


namespace DataLogicLayer
{
    public class LoggerContext : DbContext
    {
        public DbSet<Log> Logs { get; set; }

        public LoggerContext(DbContextOptions<LoggerContext> options)
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
