using System.Collections.Generic;
using System.Threading.Tasks;
using BusinessLogicLayer.Models;
using BusinessLogicLayer.Services;
using Mapster;
using Microsoft.AspNetCore.Http;
using WebApi.Models;

namespace WebApi.Services.Implementation
{
    internal class PromotionService : IPromotionService
    {
        private readonly IPromotionsBusinessService promotionsBusiness;

        public PromotionService(IPromotionsBusinessService promotionsBusiness)
        {
            this.promotionsBusiness = promotionsBusiness;
        }

        public async Task CreatePromotionAsync(PromotionInsert promotion)
        {
            var basePromotion = promotion.Adapt<PromotionBase>();
            await this.promotionsBusiness.CreatePromotionAsync(basePromotion);
        }

        public IEnumerable<Promotion> GetActivePromotions()
        {
            return this.promotionsBusiness.GetActivePromotions().Adapt<IEnumerable<Promotion>>();
        }
    }
}
