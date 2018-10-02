using System;
using System.Collections.Generic;
using System.Linq;
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
        public IList<PromotionDTO> GetActivePromotions()
        {
            var currentDt = DateTime.UtcNow;
            return this.db.Promotions.Where(el =>
            el.DtFrom >= currentDt &&
            (!el.DtTo.HasValue || el.DtTo <= currentDt)).AsParallel().ToList();
        }
    }
}
