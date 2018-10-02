using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace DataLogicLayer
{
    public class ApplicationContextFactory: IDesignTimeDbContextFactory<ApplicationContext>
    {
        public ApplicationContext Create(DbContextFactoryOptions options)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
            optionsBuilder.UseSqlServer("Server=localhost;Database=GYMDB;Trusted_Connection=True;MultipleActiveResultSets=true");

            return new ApplicationContext(optionsBuilder.Options);
        }

        public ApplicationContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
            optionsBuilder.UseSqlServer("Server=localhost;Database=GYMDB;Trusted_Connection=True;MultipleActiveResultSets=true");

            return new ApplicationContext(optionsBuilder.Options);
        }

    }
}
