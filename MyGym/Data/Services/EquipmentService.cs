using Microsoft.EntityFrameworkCore;
using MyGym.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGym.Data.Services
{
    public class EquipmentService : IEquipmentService
    {
        private readonly AppDbContext _context;

        public EquipmentService(AppDbContext context)
        {
            _context = context;
        }

        public void Add(Equipment equipment)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Equipment>> GetAll()
        {
            var result = await _context.Equipments.ToListAsync();
            return result;
        }

        public Equipment GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Equipment Update(int id, Equipment newEquipment)
        {
            throw new System.NotImplementedException();
        }
    }
}
