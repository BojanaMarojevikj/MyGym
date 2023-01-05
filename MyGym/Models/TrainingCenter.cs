using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyGym.Models
{
    public class TrainingCenter
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="Training Center Logo")]
        public string Logo { get; set; }

        [Display(Name = "Training Center Name")]
        public string Name { get; set; }

        [Display(Name = "Training Center Description")]
        public string Description { get; set; }

        //Relationships
        public List<Training> Trainings { get; set; }
    }
}
