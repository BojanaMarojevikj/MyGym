using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyGym.Data;
using MyGym.Data.Services;
using MyGym.Data.Static;
using MyGym.Models;
using System.Threading.Tasks;

namespace MyGym.Controllers
{
    [Authorize(Roles = UserRoles.Admin)]
    public class TrainingCentersController : Controller
    {
        private readonly ITrainingCentersService _service;

        public TrainingCentersController(ITrainingCentersService service)
        {
            _service = service;
        }
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var allTrainingCenters = await _service.GetAllAsync();
            return View(allTrainingCenters);
        }

        //GET: TrainingCenters/Details/1
        [AllowAnonymous]

        public async Task<IActionResult> Details(int id)
        {
            var trainingCenterDetails = await _service.GetByIdAsync(id);
            if (trainingCenterDetails == null) return View("NotFound");
            return View(trainingCenterDetails);
        }

        //GET: TrainingCenters/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Logo,Name,Description")] TrainingCenter trainingCenter)
        {
            if (!ModelState.IsValid)
            {
                return View(trainingCenter);
            }
            await _service.AddAsync(trainingCenter);
            return RedirectToAction(nameof(Index));
        }

        //GET: TrainingCenters/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var trainingCenterDetails = await _service.GetByIdAsync(id);
            if (trainingCenterDetails == null)
            {
                return View("NotFound");
            }
            return View(trainingCenterDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Logo,Name,Description")] TrainingCenter trainingCenter)
        {
            if (!ModelState.IsValid)
            {
                return View(trainingCenter);
            }
            if (id == trainingCenter.Id)
            {
                await _service.UpdateAsync(id, trainingCenter);

                return RedirectToAction(nameof(Index));
            }
            return View(trainingCenter);
        }


        //GET: TrainingCenters/Delete/1
        public async Task<IActionResult> Delete(int id)
        {
            var trainingCenterDetails = await _service.GetByIdAsync(id);
            if (trainingCenterDetails == null)
            {
                return View("NotFound");
            }
            return View(trainingCenterDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var trainingCenterDetails = await _service.GetByIdAsync(id);
            if (trainingCenterDetails == null)
            {
                return View("NotFound");
            }
            await _service.DeleteAsync(id);

            return RedirectToAction(nameof(Index));
        }
    }
}
