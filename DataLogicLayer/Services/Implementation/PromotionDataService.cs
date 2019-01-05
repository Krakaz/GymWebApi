﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLogicLayer.Models;
using Microsoft.EntityFrameworkCore;

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

        public Task DeleteAsync(int id)
        {
            var promoution = this.db.Promotions.First(el => el.Id == id);
            promoution.IsDeleted = true;
            return this.db.SaveChangesAsync();
        }

        public async Task<IList<PromotionDto>> GetActivePromotionsAsync()
        {
            var currentDt = DateTime.UtcNow;
            return await this.db.Promotions.Where(el =>
                el.IsDeleted == false &&
                el.DtFrom <= currentDt &&
                (!el.DtTo.HasValue || el.DtTo >= currentDt))
                .Include(promotion => promotion.File)
                .OrderByDescending(r => r.DtFrom)                
                .ToListAsync();
        }

        public Task<PromotionDto> GetPromotionAsync(int id)
        {
            return this.db.Promotions
                .Include(promotion => promotion.File)
                .SingleOrDefaultAsync(el => el.Id == id);
        }
    }
}