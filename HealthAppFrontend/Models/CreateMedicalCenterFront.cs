using System.ComponentModel.DataAnnotations;

namespace HealthAppFrontend.Models
{
    public class CreateMedicalCenterFront
    {
        [Required]
        public string name { get; set; }
        [Required]
        public string address { get; set; }
        [Required]
        public string phoneNumber { get; set; }
    }
}
