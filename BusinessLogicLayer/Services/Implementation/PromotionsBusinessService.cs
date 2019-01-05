using System.Collections.Generic;
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
        private readonly IFileBusinessService fileBusinessService;
        private readonly IFileDataService fileDataService;

        public PromotionsBusinessService(IPromotionDataService promotionServices,
            IFileBusinessService fileBusinessService,
            IFileDataService fileDataService)
        {
            this.promotionServices = promotionServices;
            this.fileBusinessService = fileBusinessService;
            this.fileDataService = fileDataService;
        }

        public async Task CreatePromotionAsync(PromotionBase promotion)
        {
            var fileName = await this.fileBusinessService.SaveFileAsync(promotion.Image);
            var file = new FileDto()
            {
                Name = fileName,
                ContentType = promotion.Image.ContentType,
                Label = promotion.Image.FileName
            };

            file.Id = await this.fileDataService.SaveFileAsync(file);


            var promotionDto = promotion.Adapt<PromotionDto>();
            promotionDto.FileId = file.Id;
            promotionDto.File = file;
            promotionDto.IsDeleted = false;
            await this.promotionServices.CreatePromotionAsync(promotionDto);
            promotion.Id = promotionDto.Id;
        }

        public async Task<IList<PromotionListItem>> GetActivePromotionsAsync()
        {
            var promotionDto = await this.promotionServices.GetActivePromotionsAsync();
            var promotions = new List<PromotionListItem>();
            foreach (var el in promotionDto)
            {
                var promotion = el.Adapt<PromotionListItem>();
                promotion.ImageName = el.File.Label;
                promotions.Add(promotion);
            }
            return promotions;
        }

        public async Task<PromotionBaseDetails> GetPromotionAsync(int id)
        {
            var promotionDto = await this.promotionServices.GetPromotionAsync(id);
            var promotion = promotionDto.Adapt<PromotionBaseDetails>();
            promotion.Image = (await this.fileBusinessService.GetFileAsync(promotionDto.File.Name)).ToArray();
            return promotion;
        }
    }
}
