using Common.Services;
using DataLogicLayer;
using DataLogicLayer.Services;
using DataLogicLayer.Services.Implementation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DataLogicLayer
{
    public static class DataLibraryCollectionExtentions
    {
        public static IServiceCollection AddDataLibraryCollection(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<ILogger, Logger>();
            services.AddSingleton<IPromotionDataService, PromotionDataService>();

            services.AddDbContext<LoggerContext>(options => options.UseSqlServer(configuration.GetConnectionString("LogConnection")));
            services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(configuration.GetConnectionString("ApplicationConnection")));

            return services;
        }
    }
}
