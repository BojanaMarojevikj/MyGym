using Microsoft.EntityFrameworkCore;
using MyGym.Data.Base;
using MyGym.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGym.Data.Services
{
    public class EquipmentService : EntityBaseRepository<Equipment>, IEquipmentService
    {
        
        public EquipmentService(AppDbContext context) : base(context) { }

        
    }
}
