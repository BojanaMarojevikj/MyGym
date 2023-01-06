using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyGym.Data;
using MyGym.Data.Services;
using MyGym.Models;
using System.Linq;
using System.Threading.Tasks;

namespace MyGym.Controllers
{
    public class CoachesController : Controller
    {
        private readonly ICoachesService _service;

        public CoachesController(ICoachesService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var allCoaches = await _service.GetAllAsync();
            return View(allCoaches);
        }

        //GET: Coaches/Details/1
        public async Task<IActionResult> Details(int id)
        {
            var coachDetails = await _service.GetByIdAsync(id);
            if(coachDetails == null)    return View("NotFound");
            return View(coachDetails);
        }

        //GET: Coaches/Create
        public IActionResult Create() {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("PictureURL,Name,Bio")] Coach coach)
        {
            if (!ModelState.IsValid)
            {
                return View(coach);
            }
            await _service.AddAsync(coach);
            return RedirectToAction(nameof(Index));
        }

        //GET: Coaches/Edit/1

        public async Task<IActionResult> Edit(int id)
        {
            var coachDetails = await _service.GetByIdAsync(id);
            if (coachDetails == null)
            {
                return View("NotFound");
            }
            return View(coachDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,PictureURL,Name,Bio")] Coach coach)
        {
            if (!ModelState.IsValid)
            {
                return View(coach);
            }
            if (id == coach.Id)
            {
                await _service.UpdateAsync(id, coach);

                return RedirectToAction(nameof(Index));
            }
            return View(coach);
        }

        //GET: Coaches/Delete/1

        public async Task<IActionResult> Delete(int id)
        {
            var coachDetails = await _service.GetByIdAsync(id);
            if (coachDetails == null)
            {
                return View("NotFound");
            }
            return View(coachDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var coachDetails = await _service.GetByIdAsync(id);
            if (coachDetails == null)
            {
                return View("NotFound");
            }
            await _service.DeleteAsync(id);

            return RedirectToAction(nameof(Index));
        }

    }
}
