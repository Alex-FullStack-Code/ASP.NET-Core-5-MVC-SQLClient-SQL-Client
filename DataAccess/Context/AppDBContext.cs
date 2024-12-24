
using Microsoft.EntityFrameworkCore;
using Models.Entities;

namespace DataAccess.Context
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }
        public DbSet<Doctor> doctors { get; set; }
        //public DbSet<MedicalCenter> medicalCenters { get; set; }
        //public DbSet<ClinicalSpecialty> clinicalSpecialties { get; set; }

    }
}
