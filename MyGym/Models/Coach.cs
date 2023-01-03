using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyGym.Models
{
    public class Coach
    {
        [Key]
        public int Id { get; set; }

        public string PictureURL { get; set; }

        public string Name { get; set; }

        public string Bio { get; set; }

        //Relationships
        public List<Training> Trainings { get; set; }
    }
}
