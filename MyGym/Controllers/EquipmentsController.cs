using Microsoft.AspNetCore.Mvc;
using MyGym.Data;
using MyGym.Data.Services;
using System.Linq;
using System.Threading.Tasks;

namespace MyGym.Controllers
{
    public class EquipmentsController : Controller
    {
        private readonly IEquipmentService _service;

        public EquipmentsController(IEquipmentService service) { 
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAll();
            return View(data);
        }
    }
}
