using System.Collections.Generic;
using System.Threading.Tasks;
using BusinessLogicLayer.Models;
using BusinessLogicLayer.Services;
using Mapster;
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

        public async Task<int> CreatePromotionAsync(PromotionUpsert promotion)
        {
            var basePromotion = promotion.Adapt<PromotionBase>();
            await this.promotionsBusiness.CreatePromotionAsync(basePromotion);
            return basePromotion.Id;
        }

        public async Task<IEnumerable<Promotion>> GetActivePromotionsAsync()
        {
            return (await this.promotionsBusiness.GetActivePromotionsAsync()).Adapt<IEnumerable<Promotion>>();
        }

        public async Task<PromotionDetails> GetPromotionAsync(int id)
        {
            var promotionBase = await this.promotionsBusiness.GetPromotionAsync(id);
            var promotionDetails = promotionBase.Adapt<PromotionDetails>();
            return promotionDetails;
        }

        public Task DeletePromotionAsync(int id)
        {
            return this.promotionsBusiness.DeletePromotionAsync(id);
        }
    }
}
