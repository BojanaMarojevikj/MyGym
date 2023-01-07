using MyGym.Data.Base;
using MyGym.Models;

namespace MyGym.Data.Services
{
    public class TrainingCentersService : EntityBaseRepository<TrainingCenter>, ITrainingCentersService
    {
        public TrainingCentersService(AppDbContext context): base(context)
        {

        }
    }
}
