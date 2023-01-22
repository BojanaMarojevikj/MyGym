using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyGym.Data;
using MyGym.Data.Services;
using MyGym.Data.Static;
using MyGym.Models;
using System.Linq;
using System.Threading.Tasks;

namespace MyGym.Controllers
{
    [Authorize(Roles = UserRoles.Admin)]
    public class EquipmentsController : Controller
    {
        
        private readonly IEquipmentService _service;

        public EquipmentsController(IEquipmentService service) { 
            _service = service;
        }
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync();
            return View(data);
        }

        //Get: Equipments/Create
        public IActionResult Create() {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("PictureURL,Name,Description")]Equipment equipment)
        {
            if (!ModelState.IsValid) {
                return View(equipment);
            }
            await _service.AddAsync(equipment);
            return RedirectToAction(nameof(Index));
        }

        //Get: Equipments/Details/1
        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var equipmentDetails = await _service.GetByIdAsync(id);
            if (equipmentDetails == null)
            {
                return View("NotFound");
            }
            return View(equipmentDetails);
        }

        //Get: Equipments/Edit/1

        public async Task<IActionResult> Edit(int id)
        {
            var equipmentDetails = await _service.GetByIdAsync(id);
            if (equipmentDetails == null)
            {
                return View("NotFound");
            }
            return View(equipmentDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,PictureURL,Name,Description")] Equipment equipment)
        {
            if (!ModelState.IsValid)
            {
                return View(equipment);
            }
            await _service.UpdateAsync(id, equipment);
            return RedirectToAction(nameof(Index));
        }


        //Get: Equipments/Delete/1

        public async Task<IActionResult> Delete(int id)
        {
            var equipmentDetails = await _service.GetByIdAsync(id);
            if (equipmentDetails == null)
            {
                return View("NotFound");
            }
            return View(equipmentDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var equipmentDetails = await _service.GetByIdAsync(id);
            if (equipmentDetails == null)
            {
                return View("NotFound");
            }
            await _service.DeleteAsync(id);
            
            return RedirectToAction(nameof(Index));
        }
    }
}
