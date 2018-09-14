using Common.Services;
using Common.Services.Implementation;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Common
{
    public static class CommonLibraryCollectionExtentions
    {
        public static IServiceCollection AddCommonLibraryCollection(this IServiceCollection services)
        {
            services.AddSingleton<ICustomLogger, CustomLogger>();

            return services;
        }
    }
}
