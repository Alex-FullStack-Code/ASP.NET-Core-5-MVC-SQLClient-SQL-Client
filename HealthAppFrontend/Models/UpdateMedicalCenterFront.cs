using System.ComponentModel.DataAnnotations;

namespace HealthAppFrontend.Models
{
    public class UpdateMedicalCenterFront
    {
        //public int id { get; set; }

        [Required]
        public string name { get; set; }

        [Required]
        public string phoneNumber { get; set; }

    }
}
