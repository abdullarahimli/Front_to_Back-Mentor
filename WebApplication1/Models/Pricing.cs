using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Pricing
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public bool IsFeature { get; set; }

        public bool IsUltimate { get; set; }

        public List<PricingFeatureItems> PricingFeatureItems { get; set; }

    }
}
