using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.DAL;
using WebApplication1.Models;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class PricingController : Controller
    {
        private readonly AppDbContext _context;
        public PricingController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ViewBag.page = "pricing";

            List<FeatureItems> featureItems = _context.FeatureItems.ToList();
            List<Pricing> pricings = _context.Pricings.Include(p => p.PricingFeatureItems).ToList();

            PricingViewModel pricingViewModel = new PricingViewModel()
            {
                FeatureItems = featureItems,
                Pricings = pricings
            };
            return View(pricingViewModel);
        }
    }
}
