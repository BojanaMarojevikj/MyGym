using Microsoft.AspNetCore.Mvc;
using MyGym.Data;
using System.Linq;

namespace MyGym.Controllers
{
    public class EquipmentsController : Controller
    {
        private readonly AppDbContext _context;

        public EquipmentsController(AppDbContext context) { 
            _context = context;
        }
        public IActionResult Index()
        {
            var data = _context.Equipments.ToList();
            return View(data);
        }
    }
}
