using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.ViewModels
{
    public class PricingViewModel
    {
        public List<FeatureItems> FeatureItems { get; set; }
        public List<Pricing> Pricings { get; set; }
    }
}
