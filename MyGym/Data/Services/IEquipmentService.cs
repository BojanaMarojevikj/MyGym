using MyGym.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyGym.Data.Services
{
    public interface IEquipmentService
    {
        Task<IEnumerable<Equipment>> GetAllAsync();

        Task<Equipment> GetByIdAsync(int id);

        Task AddAsync(Equipment equipment);

        Task<Equipment> UpdateAsync(int id, Equipment newEquipment);

        Task DeleteAsync(int id);
    }
}
