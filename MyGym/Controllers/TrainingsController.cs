using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyGym.Data;
using System.Linq;
using System.Threading.Tasks;

namespace MyGym.Controllers
{
    public class TrainingsController : Controller
    {
        private readonly AppDbContext _context;

        public TrainingsController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allTrainings = await _context.Trainings.Include(n => n.TrainingCenter).OrderBy(n => n.Name).ToListAsync();
            return View(allTrainings);
        }
    }
}
