using System.ComponentModel.DataAnnotations;

namespace HealthAppFrontend.Models
{
    public class CreateClinicalSpecialtyFront
    {
        [Required]
        public string field { get; set; }
        [Required]
        public string specialty { get; set; }
        [Required]
        public string description { get; set; }
    }
}
