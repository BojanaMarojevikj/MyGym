using MyGym.Data.Base;
using MyGym.Data.ViewModels;
using MyGym.Models;
using System.Threading.Tasks;

namespace MyGym.Data.Services
{
    public interface ITrainingsService : IEntityBaseRepository<Training>
    {
        Task<Training> GetTrainingByIdAsync(int id);

        Task<NewTrainingDropdownsVM> GetNewTrainingDropdownsValues();

        Task AddNewTrainingAsync(NewTrainingVM data);

        Task UpdateTrainingAsync(NewTrainingVM data);
    }
}
