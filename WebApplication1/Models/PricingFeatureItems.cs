using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class PricingFeatureItems
    {
        public int Id { get; set; }
        public Pricing Pricing { get; set; }
        public int PricingId { get; set; }
        public FeatureItems FeatureItems { get; set; }
        public int FeatureItemsId { get; set; }

    }
}
