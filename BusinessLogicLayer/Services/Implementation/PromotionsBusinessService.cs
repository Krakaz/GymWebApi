using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using BusinessLogicLayer.Models;
using DataLogicLayer.Models;
using DataLogicLayer.Services;
using Mapster;

namespace BusinessLogicLayer.Services.Implementation
{
    internal class PromotionsBusinessService : IPromotionsBusinessService
    {
        private readonly IPromotionDataService promotionServices;
        private readonly string promotionImagePath = "wwwroot/promotionImages/";

        public PromotionsBusinessService(IPromotionDataService promotionServices)
        {
            this.promotionServices = promotionServices;
        }

        public async Task CreatePromotionAsync(PromotionBase promotion)
        {
            if (promotion.Image == null || promotion.Image.Length == 0)
            {
                throw new ArgumentNullException("Изображение не выбрано");
            }

            var path = Path.Combine(
                        Directory.GetCurrentDirectory(), promotionImagePath,
                        promotion.Image.FileName);

            using (var stream = new FileStream(path, FileMode.Create))
            {
                await promotion.Image.CopyToAsync(stream);
            }

            var promotionDto = promotion.Adapt<PromotionDTO>();
            promotionDto.ImageUrl = Path.Combine(promotionImagePath,
                        promotion.Image.FileName);
            promotionDto.IsDeleted = false;
            await this.promotionServices.CreatePromotionAsync(promotionDto);
        }

        public IList<PromotionDTO> GetActivePromotions()
        {
            return this.promotionServices.GetActivePromotions();
        }
    }
}
