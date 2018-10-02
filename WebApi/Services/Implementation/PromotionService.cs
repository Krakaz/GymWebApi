using System.Collections.Generic;
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
        public IEnumerable<Promotion> GetActivePromotions()
        {
            return this.promotionsBusiness.GetActivePromotions().Adapt<IEnumerable<Promotion>>();
        }
    }
}
