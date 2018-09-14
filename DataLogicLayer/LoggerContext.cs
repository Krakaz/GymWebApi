using DataLogicLayer.Models;
using Microsoft.EntityFrameworkCore;


namespace DataLogicLayer
{
    public class LoggerContext : DbContext
    {
        public DbSet<Log> Logs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer("Server=localhost;Database=logs;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        public LoggerContext(DbContextOptions<LoggerContext> options)
            : base(options)
        {
            Database.EnsureCreated();            
        }

    }
}
