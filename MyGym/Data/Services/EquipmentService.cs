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

        public async Task AddAsync(Equipment equipment)
        {

            await _context.Equipments.AddAsync(equipment);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var result = await _context.Equipments.FirstOrDefaultAsync(n => n.Id == id);
            _context.Equipments.Remove(result);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Equipment>> GetAllAsync()
        {
            var result = await _context.Equipments.ToListAsync();
            return result;
        }

        public async Task<Equipment> GetByIdAsync(int id)
        {
            var result = await _context.Equipments.FirstOrDefaultAsync(n => n.Id == id);
            return result;
        }

        public async Task<Equipment> UpdateAsync(int id, Equipment newEquipment)
        {
            _context.Update(newEquipment);
            await _context.SaveChangesAsync();
            return newEquipment;
        }
    }
}
