
using Models.Entities;
using System.Collections.Generic;

namespace Models.Interfaces
{
    public interface IClinicalRepository<T> where T : IEntity
    {
        bool CreateSpecialty(T entity);
        IEnumerable<ClinicalSpecialty> GetAllSpecialties();
        ClinicalSpecialty GetSpecialty(int id);
        bool RemoveSpecialty(int id);
        bool UpdateSpecialty(T entity);
    }
}
