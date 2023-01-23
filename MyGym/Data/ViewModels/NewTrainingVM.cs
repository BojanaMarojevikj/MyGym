using MyGym.Data;
using MyGym.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyGym.Models
{
    public class NewTrainingVM
    {
        public int Id { get; set; }

        [Display(Name="Training name")]
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Display(Name = "Training description")]
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }

        [Display(Name = "Price")]
        [Required(ErrorMessage = "Price is required")]
        public double Price { get; set; }

        [Display(Name = "Image")]
        [Required(ErrorMessage = "Image is required")]
        public string ImageURL { get; set; }

        [Display(Name = "Start date")]
        [Required(ErrorMessage = "Start date is required")]
        public DateTime StartDate { get; set; }

        [Display(Name = "End date name")]
        [Required(ErrorMessage = "End date is required")]
        public DateTime EndDate { get; set; }

        [Display(Name = "Select the level")]
        [Required(ErrorMessage = "Level is required")]
        public TrainingCategory TrainingCategory { get; set; }

        //Relationships
        [Display(Name = "Select equipment")]
        [Required(ErrorMessage = "Equipment is required")]
        public List<int> EquipmentsIds { get; set; }

        //Training center
        [Display(Name = "Select a training center")]
        [Required(ErrorMessage = "Training center is required")]
        public int TrainingCenterId { get; set; }


        //Coach
        [Display(Name = "Select a coach")]
        [Required(ErrorMessage = "Coach is required")]
        public int CoachId { get; set; }
        

    }
}
