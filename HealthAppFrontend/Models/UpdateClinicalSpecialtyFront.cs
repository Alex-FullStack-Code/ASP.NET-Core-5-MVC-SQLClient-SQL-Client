using System.ComponentModel.DataAnnotations;

namespace HealthAppFrontend.Models
{
    public class UpdateClinicalSpecialtyFront
    {
        [Required]
        public string description { get; set; }
    }
}
