using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyGym.Models
{
    public class Equipment
    {
        [Key]
        public int Id { get; set; }

        public string PictureURL { get; set; }

        public string Name { get; set; }

        public string Bio { get; set; }

        //Relationships
        public List<Equipment_Training> Equipments_Trainings { get; set; }

    }
}
