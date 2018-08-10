using System.Data.SqlClient;
using System.IO;
using Microsoft.Extensions.Configuration;
using SimpleMigrations;
using SimpleMigrations.Console;
using SimpleMigrations.DatabaseProvider;

namespace Migrator
{
    /// <summary>
    /// Утилита выполнения миграций
    /// См. https://github.com/canton7/Simple.Migrations
    /// Для разработчиков:
    /// Миграции добавляются в папку Migrations
    /// Формат наименования файла __YYYY_MM_DD_hh_mm_Description
    /// Атрибут Migration для файла [YYYY_MM_DD_hh_mm, "Description"]
    /// Реализуем и Up(), и Down()!
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Run migrator
        /// </summary>
        /// <param name="args">
        ///     up: Migrate to the latest version (default)
        ///     to <n>: Migrate up/down to the version n (0 for reset)
        ///     reapply: Re-apply the current migration
        ///     list: List all available migrations
        ///     baseline <n>: Move the database to version n, without apply migrations
        /// </param>
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            string connectionString = builder.GetConnectionString("DefaultConnection");

            var migrationsAssembly = typeof(Program).Assembly;
            using (var db = new SqlConnection(connectionString))
            {
                var databaseProvider = new MssqlDatabaseProvider(db);
                var migrator = new SimpleMigrator(migrationsAssembly, databaseProvider);
                migrator.Load();

                var consoleRunner = new ConsoleRunner(migrator);
                consoleRunner.Run(args);
            }
        }
    }
}
