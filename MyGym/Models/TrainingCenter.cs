using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyGym.Models
{
    public class TrainingCenter
    {
        [Key]
        public int Id { get; set; }

        public string Logo { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        //Relationships
        public List<Training> Trainings { get; set; }
    }
}
