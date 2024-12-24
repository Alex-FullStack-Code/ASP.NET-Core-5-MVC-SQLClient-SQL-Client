using Models.Interfaces;

namespace Models.Entities
{
    public class Doctor : IEntity
    {
        public int id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string birthdate { get; set; }
        public string career { get; set; }
        public string graduation_date { get; set; }
        public string phone_number { get; set; }
        public string email { get; set; }
        public string field { get; set; }
        public string specialty { get; set; }
        public string description { get; set; }
        public string center { get; set; }
        public string centerAddress { get; set; }
        public string centerPhoneNumber { get; set; }
    }
}
