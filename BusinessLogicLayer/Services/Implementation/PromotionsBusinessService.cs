using System.Collections.Generic;
using DataLogicLayer.Models;
using DataLogicLayer.Services;

namespace BusinessLogicLayer.Services.Implementation
{
    internal class PromotionsBusinessService : IPromotionsBusinessService
    {
        private readonly IPromotionDataService promotionServices;

        public PromotionsBusinessService(IPromotionDataService promotionServices)
        {
            this.promotionServices = promotionServices;
        }
        public IList<PromotionDTO> GetActivePromotions()
        {
            return this.promotionServices.GetActivePromotions();
        }
    }
}
