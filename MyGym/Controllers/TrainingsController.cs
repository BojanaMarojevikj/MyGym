using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyGym.Data;
using MyGym.Data.Services;
using MyGym.Data.Static;
using MyGym.Models;
using System.Linq;
using System.Threading.Tasks;

namespace MyGym.Controllers
{
    [Authorize(Roles = UserRoles.Admin)]
    public class TrainingsController : Controller
    {
        private readonly ITrainingsService _service;

        public TrainingsController(ITrainingsService service)
        {
            _service = service;
        }
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var allTrainings = await _service.GetAllAsync(n => n.TrainingCenter); 
            return View(allTrainings);
        }

        [AllowAnonymous]
        public async Task<IActionResult> Filter(string searchString)
        {
            var allTrainings = await _service.GetAllAsync(n => n.TrainingCenter);

            if (!string.IsNullOrEmpty(searchString))
            {
                var filteredResult = allTrainings.Where(n => n.Name.Contains(searchString)
                || n.Description.Contains(searchString)).ToList();
                return View("Index", filteredResult);
            }

            return View("Index", allTrainings);
        }

        //GET: Trainings/Details/1
        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var trainingDetails = await _service.GetTrainingByIdAsync(id);
            if (trainingDetails == null) return View("NotFound");
            return View(trainingDetails);
        }

        //GET: Trainings/Create
        public async Task<IActionResult> Create()
        {
            var trainingDropdownsData = await _service.GetNewTrainingDropdownsValues();

            ViewBag.TrainingCenters = new SelectList(trainingDropdownsData.TrainingCenters, "Id", "Name");
            ViewBag.Coaches = new SelectList(trainingDropdownsData.Coaches, "Id", "Name");
            ViewBag.Equipments = new SelectList(trainingDropdownsData.Equipments, "Id", "Name");
            return View();
        }

        
        [HttpPost]
        public async Task<IActionResult> Create(NewTrainingVM training)
        {
            if (!ModelState.IsValid)
            {
                var trainingDropdownsData = await _service.GetNewTrainingDropdownsValues();

                ViewBag.TrainingCenters = new SelectList(trainingDropdownsData.TrainingCenters, "Id", "Name");
                ViewBag.Coaches = new SelectList(trainingDropdownsData.Coaches, "Id", "Name");
                ViewBag.Equipments = new SelectList(trainingDropdownsData.Equipments, "Id", "Name");

                return View(training);
            }

            await _service.AddNewTrainingAsync(training);
            return RedirectToAction(nameof(Index));
        }

        //GET: Trainings/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var trainingDetails = await _service.GetTrainingByIdAsync(id);
            if (trainingDetails == null) return View("NotFound");

            var response = new NewTrainingVM()
            {
                Id = trainingDetails.Id,
                Name = trainingDetails.Name,
                Description = trainingDetails.Description,
                Price = trainingDetails.Price,
                StartDate = trainingDetails.StartDate,
                EndDate = trainingDetails.EndDate,
                ImageURL = trainingDetails.ImageURL,
                TrainingCategory = trainingDetails.TrainingCategory,
                TrainingCenterId = trainingDetails.TrainingCenterId,
                CoachId = trainingDetails.CoachId,
                EquipmentsIds = trainingDetails.Equipments_Trainings.Select(n => n.EquipmentId).ToList()
            };
            
            var trainingDropdownsData = await _service.GetNewTrainingDropdownsValues();

            ViewBag.TrainingCenters = new SelectList(trainingDropdownsData.TrainingCenters, "Id", "Name");
            ViewBag.Coaches = new SelectList(trainingDropdownsData.Coaches, "Id", "Name");
            ViewBag.Equipments = new SelectList(trainingDropdownsData.Equipments, "Id", "Name");
            return View(response);
        }


        [HttpPost]
        public async Task<IActionResult> Edit(int id, NewTrainingVM training)
        {
            if (id != training.Id) return View("NotFound");
            if (!ModelState.IsValid)
            {
                var trainingDropdownsData = await _service.GetNewTrainingDropdownsValues();

                ViewBag.TrainingCenters = new SelectList(trainingDropdownsData.TrainingCenters, "Id", "Name");
                ViewBag.Coaches = new SelectList(trainingDropdownsData.Coaches, "Id", "Name");
                ViewBag.Equipments = new SelectList(trainingDropdownsData.Equipments, "Id", "Name");

                return View(training);
            }

            await _service.UpdateTrainingAsync(training);
            return RedirectToAction(nameof(Index));
        }
    }
}
