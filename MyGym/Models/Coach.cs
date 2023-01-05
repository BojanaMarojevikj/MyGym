using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyGym.Models
{
    public class Coach
    {
        [Key]
        public int Id { get; set; }

        [Display(Name="Picture")]
        public string PictureURL { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Biography")]
        public string Bio { get; set; }

        //Relationships
        public List<Training> Trainings { get; set; }
    }
}
