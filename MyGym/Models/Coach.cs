using MyGym.Data.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyGym.Models
{
    public class Coach:IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name="Picture")]
        [Required(ErrorMessage ="Picutre is required")]
        public string PictureURL { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 characters")]
        public string Name { get; set; }

        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Biography is required")]
        public string Bio { get; set; }

        //Relationships
        public List<Training> Trainings { get; set; }
    }
}
