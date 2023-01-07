using MyGym.Data.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyGym.Models
{
    public class TrainingCenter : IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="Training Center Logo")]
        [Required(ErrorMessage = "Logo is required")]
        public string Logo { get; set; }

        [Display(Name = "Training Center Name")]
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Display(Name = "Training Center Description")]
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }

        //Relationships
        public List<Training> Trainings { get; set; }
    }
}
