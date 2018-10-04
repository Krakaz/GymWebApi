using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLogicLayer.Models;

namespace DataLogicLayer.Services.Implementation
{
    internal class PromotionDataService : IPromotionDataService
    {
        private ApplicationContext db;
        public PromotionDataService(ApplicationContext context)
        {
            db = context;
        }

        public async Task CreatePromotionAsync(PromotionDto promotion)
        {
            this.db.Promotions.Add(promotion);
            await this.db.SaveChangesAsync();
        }

        public IList<PromotionDto> GetActivePromotions()
        {
            var currentDt = DateTime.UtcNow;
            return this.db.Promotions.Where(el =>
                el.IsDeleted == true &&
                el.DtFrom <= currentDt &&
                (!el.DtTo.HasValue || el.DtTo >= currentDt))
                .AsParallel()
                .OrderByDescending(r => r.DtFrom)
                .ToList();
        }
    }
}
