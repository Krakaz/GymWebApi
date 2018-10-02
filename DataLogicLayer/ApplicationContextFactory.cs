using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;

namespace DataLogicLayer
{
    public class ApplicationContextFactory: IDesignTimeDbContextFactory<ApplicationContext>
    {
        private readonly IConfiguration configuration;

        public ApplicationContextFactory(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public ApplicationContext Create(DbContextFactoryOptions options)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
            optionsBuilder.UseSqlServer(this.configuration.GetConnectionString("ApplicationConnection"));

            return new ApplicationContext(optionsBuilder.Options);
        }

        public ApplicationContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
            optionsBuilder.UseSqlServer(this.configuration.GetConnectionString("ApplicationConnection"));

            return new ApplicationContext(optionsBuilder.Options);
        }

    }
}
