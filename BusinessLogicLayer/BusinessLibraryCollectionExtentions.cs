using BusinessLogicLayer.Services;
using BusinessLogicLayer.Services.Implementation;
using Microsoft.Extensions.DependencyInjection;

namespace BusinessLogicLayer
{
    public static class BusinessLibraryCollectionExtentions
    {
        public static IServiceCollection AddBusinessLibraryCollection(this IServiceCollection services)
        {
            services.AddSingleton<IPromotionsBusinessService, PromotionsBusinessService>();

            return services;
        }
    }
}
