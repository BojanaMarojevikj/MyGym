using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyGym.Data;
using System.Threading.Tasks;

namespace MyGym.Controllers
{
    public class TrainingCentersController : Controller
    {
        private readonly AppDbContext _context;

        public TrainingCentersController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allTrainingCenters = await _context.TrainingCenters.ToListAsync();
            return View(allTrainingCenters);
        }
    }
}
