namespace HealthAppFrontend.Models
{
    public class DoctorFront
    {
        public int id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string birthdate { get; set; }

        public string graduation_date { get; set; }
        public string phone_number { get; set; }
        public string email { get; set; }

        public string specialty { get; set; }

        public string center { get; set; }

    }
}
