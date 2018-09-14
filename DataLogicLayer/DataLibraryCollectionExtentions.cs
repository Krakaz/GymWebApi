using Common.Services;
using DataLogicLayer;
using DataLogicLayer.Services.Implementation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Common
{
    public static class DataLibraryCollectionExtentions
    {
        public static IServiceCollection AddDataLibraryCollection(this IServiceCollection services)
        {
            services.AddSingleton<ILogger, Logger>();

            var defaultConnection = "Server=localhost;Database=logs;Trusted_Connection=True;MultipleActiveResultSets=true";
            services.AddDbContext<LoggerContext>(options => options.UseSqlServer(defaultConnection));

            return services;
        }
    }
}
