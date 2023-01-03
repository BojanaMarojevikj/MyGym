namespace MyGym.Models
{
    public class Equipment_Training
    {
        public int EquipmentId { get; set; }
        public Equipment Equipment { get; set; }
        
        public int TrainingId { get; set; }
        public Training Training { get; set; }
    }
}
