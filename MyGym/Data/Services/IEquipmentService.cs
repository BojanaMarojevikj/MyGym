using MyGym.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyGym.Data.Services
{
    public interface IEquipmentService
    {
        Task<IEnumerable<Equipment>> GetAll();

        Equipment GetById(int id);

        void Add(Equipment equipment);

        Equipment Update(int id, Equipment newEquipment);

        void Delete(int id);
    }
}
