using Microsoft.EntityFrameworkCore;
using MyGym.Data.Base;
using MyGym.Data.ViewModels;
using MyGym.Models;
using System.Linq;
using System.Threading.Tasks;

namespace MyGym.Data.Services
{
    public class TrainingsService : EntityBaseRepository<Training>, ITrainingsService
    {
        private readonly AppDbContext _context;
        public TrainingsService(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task AddNewTrainingAsync(NewTrainingVM data)
        {
            var newTraining = new Training()
            {
                Name = data.Name,
                Description = data.Description,
                Price = data.Price,
                ImageURL = data.ImageURL,
                TrainingCenterId = data.TrainingCenterId,
                StartDate = data.StartDate,
                EndDate = data.EndDate,
                TrainingCategory = data.TrainingCategory,
                CoachId = data.CoachId
            };

            await _context.Trainings.AddAsync(newTraining);
            await _context.SaveChangesAsync();

            //Add Training Equipment
            foreach(var equipmentId in data.EquipmentsIds)
            {
                var newEquipmentTraining = new Equipment_Training() { 
                    TrainingId = newTraining.Id,
                    EquipmentId = equipmentId
                };
                await _context.Equipments_Trainings.AddAsync(newEquipmentTraining);
            }
            await _context.SaveChangesAsync();
        }

        public async Task<NewTrainingDropdownsVM> GetNewTrainingDropdownsValues()
        {
            var response = new NewTrainingDropdownsVM();
            response.Equipments = await _context.Equipments.OrderBy(n => n.Name).ToListAsync();
            response.TrainingCenters = await _context.TrainingCenters.OrderBy(n => n.Name).ToListAsync();
            response.Coaches = await _context.Coaches.OrderBy(n => n.Name).ToListAsync();
            return response;
        }

        public async Task<Training> GetTrainingByIdAsync(int id)
        {
            var trainingDetails = await _context.Trainings
                .Include(t => t.TrainingCenter)
                .Include(c => c.Coach)
                .Include(et => et.Equipments_Trainings).ThenInclude(e => e.Equipment)
                .FirstOrDefaultAsync(n => n.Id == id);
            return trainingDetails;
        }

        public async Task UpdateTrainingAsync(NewTrainingVM data)
        {
            var dbTraining = await _context.Trainings.FirstOrDefaultAsync(n => n.Id == data.Id);

            if (dbTraining != null) {

                dbTraining.Name = data.Name;
                dbTraining.Description = data.Description;
                dbTraining.Price = data.Price;
                dbTraining.ImageURL = data.ImageURL;
                dbTraining.TrainingCenterId = data.TrainingCenterId;
                dbTraining.StartDate = data.StartDate;
                dbTraining.EndDate = data.EndDate;
                dbTraining.TrainingCategory = data.TrainingCategory;
                dbTraining.CoachId = data.CoachId;
               
                await _context.SaveChangesAsync();
            }

            //Remove existing equipment
            var existingEquipmentDb = _context.Equipments_Trainings.Where(n => n.TrainingId == data.Id).ToList();
            _context.Equipments_Trainings.RemoveRange(existingEquipmentDb);
            await _context.SaveChangesAsync();

            //Add Training Equipment
            foreach (var equipmentId in data.EquipmentsIds)
            {
                var newEquipmentTraining = new Equipment_Training()
                {
                    TrainingId = data.Id,
                    EquipmentId = equipmentId
                };
                await _context.Equipments_Trainings.AddAsync(newEquipmentTraining);
            }
            await _context.SaveChangesAsync();
        }
    }
}
