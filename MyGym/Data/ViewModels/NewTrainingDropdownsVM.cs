using MyGym.Models;
using System.Collections.Generic;

namespace MyGym.Data.ViewModels
{
    public class NewTrainingDropdownsVM
    {
        public NewTrainingDropdownsVM() { 
            Coaches = new List<Coach>();
            TrainingCenters = new List<TrainingCenter>();
            Equipments = new List<Equipment>();

        }
        public List<Coach> Coaches { get; set; }

        public List<TrainingCenter> TrainingCenters { get; set; }

        public List<Equipment> Equipments { get; set; }
    }
}
