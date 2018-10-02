using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;

namespace DataLogicLayer
{
    public class LoggerContextFactory : IDesignTimeDbContextFactory<LoggerContext>
    {
        private readonly IConfiguration configuration;

        public LoggerContextFactory(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public LoggerContext Create(DbContextFactoryOptions options)
        {
            var optionsBuilder = new DbContextOptionsBuilder<LoggerContext>();
            optionsBuilder.UseSqlServer(this.configuration.GetConnectionString("LogConnection"));

            return new LoggerContext(optionsBuilder.Options);
        }

        public LoggerContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<LoggerContext>();
            optionsBuilder.UseSqlServer(this.configuration.GetConnectionString("LogConnection"));

            return new LoggerContext(optionsBuilder.Options);
        }

    }
}
