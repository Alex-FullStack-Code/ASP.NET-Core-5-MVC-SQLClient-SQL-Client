using Models.Interfaces;


namespace Models.Entities
{
    public class ClinicalSpecialty : IEntity
    {
        public int id { get; set; }
        public string field { get; set; }
        public string specialty { get; set; }
        public string description { get; set; }
    }
}
