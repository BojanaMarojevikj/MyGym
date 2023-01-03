using MyGym.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyGym.Models
{
    public class Training
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        public string ImageURL { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public TrainingCategory TrainingCategory { get; set; }

        //Relationships
        public List<Equipment_Training> Equipments_Trainings { get; set; }

        //Training center
        public int TrainingCenterId { get; set; }
        [ForeignKey("TrainingCenterId")]
        public TrainingCenter TrainingCenter { get; set; }

        //Coach
        public int CoachId { get; set; }
        [ForeignKey("CoachId")]
        public Coach Coach { get; set; }

    }
}
