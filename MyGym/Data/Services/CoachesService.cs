using MyGym.Data.Base;
using MyGym.Models;

namespace MyGym.Data.Services
{
    public class CoachesService : EntityBaseRepository<Coach>, ICoachesService
    {
        public CoachesService(AppDbContext context): base(context)
        {

        }
    }
}
