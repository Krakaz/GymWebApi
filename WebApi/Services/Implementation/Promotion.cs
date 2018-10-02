using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Services.Implementation
{
    internal class Promotion : IPromotions
    {
        public Promotion()
        {

        }
        public Task<IEnumerable<Models.Promotion>> GetActivePromotions()
        {
            throw new NotImplementedException();
        }
    }
}
