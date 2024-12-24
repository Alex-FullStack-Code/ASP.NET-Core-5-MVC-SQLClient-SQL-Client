using System.ComponentModel.DataAnnotations;

namespace HealthAppFrontend.Models
{
    public class CreateDoctorFront
    {
        [Required]
        public string firstname { get; set; }
        [Required]
        public string lastname { get; set; }
        [Required]
        public string birthdate { get; set; }
        [Required]
        public string graduation_date { get; set; }
        [Required]
        public string phone_number { get; set; }
        [Required]
        public string email { get; set; }
        [Required]
        public string specialty { get; set; }
        [Required]
        public string center { get; set; }
    }
}
