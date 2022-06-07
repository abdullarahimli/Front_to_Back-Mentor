using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.DAL;

namespace WebApplication1.Controllers
{
    public class TrainersController : Controller
    {

        private readonly AppDbContext _context;

        public TrainersController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ViewBag.page = "trainer";
            return View(_context.Trainers.Include(t => t.TrainerPosition).ToList());
        }
    }
}
