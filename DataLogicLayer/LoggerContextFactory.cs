using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace DataLogicLayer
{
    public class LoggerContextFactory
    {
        public LoggerContext Create(DbContextFactoryOptions options)
        {
            var optionsBuilder = new DbContextOptionsBuilder<LoggerContext>();
            optionsBuilder.UseSqlServer("Server=localhost;Database=logs;Trusted_Connection=True;MultipleActiveResultSets=true");

            return new LoggerContext(optionsBuilder.Options);
        }

        public LoggerContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<LoggerContext>();
            optionsBuilder.UseSqlServer("Server=localhost;Database=logs;Trusted_Connection=True;MultipleActiveResultSets=true");

            return new LoggerContext(optionsBuilder.Options);
        }

    }
}
