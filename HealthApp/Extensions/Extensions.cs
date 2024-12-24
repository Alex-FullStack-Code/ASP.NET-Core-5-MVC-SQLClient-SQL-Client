using HealthApp.Dtos;
using Models.Entities;

namespace HealthApp.Extensions
{
    public static class Extensions
    {
        public static DoctorDto AsDto(this Doctor doctor)
        {
            return new DoctorDto(doctor.id, doctor.firstname, doctor.lastname, doctor.birthdate, doctor.graduation_date, doctor.phone_number, doctor.email, doctor.specialty, doctor.center);
        }

        public static ClinicalSpecialtyDto AsDto(this ClinicalSpecialty clinicalSpecialty)
        {
            return new ClinicalSpecialtyDto(clinicalSpecialty.id, clinicalSpecialty.field, clinicalSpecialty.specialty, clinicalSpecialty.description);
        }

        public static MedicalCenterDto AsDto(this MedicalCenter medicalCenter)
        {
            return new MedicalCenterDto(medicalCenter.id, medicalCenter.name, medicalCenter.address, medicalCenter.phoneNumber);
        }
    }
}
