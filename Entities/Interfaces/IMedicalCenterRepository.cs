
using Models.Entities;
using System.Collections.Generic;

namespace Models.Interfaces
{    
    public interface IMedicalCenterRepository<T> where T : IEntity
    {
        bool CreateCenter(T entity);
        IEnumerable<MedicalCenter> GetAllCenters();
        MedicalCenter GetCenter(int id);
        bool RemoveCenter(int id);
        bool UpdateCenter(T entity);
    }
}
