using System.ComponentModel.DataAnnotations;

namespace HealthAppFrontend.Models
{
    public class ClinicalSpecialtyFront
    {
        public int id { get; set; }
        public string field { get; set; }
        public string specialty { get; set; }
        public string description { get; set; }
    }
}
