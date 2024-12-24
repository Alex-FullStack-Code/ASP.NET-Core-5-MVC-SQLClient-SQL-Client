using DataAccess.Repositories;
using HealthApp.Dtos;
using Microsoft.AspNetCore.Mvc;
using Models.Entities;
using Models.Interfaces;
using System.Collections.Generic;
using HealthApp.Extensions;
using System.Linq;

namespace HealthApp.Controllers
{
    [ApiController]
    [Route("doctores")]
    public class DoctorController : ControllerBase
    {
        private readonly DoctorRepository doctorRepository;

        public DoctorController(IDoctorRepository<Doctor> doctorRepository)
        {
            this.doctorRepository = (DoctorRepository)doctorRepository;
        }

        [HttpPost]
        public IActionResult CreateDoctor(CreateDoctorDto createDoctorDto)
        {

            var doctor = new Doctor
            {
                firstname = createDoctorDto.firstName,
                lastname = createDoctorDto.lastName,
                birthdate = createDoctorDto.birthdate,
                graduation_date = createDoctorDto.graduation_date,
                phone_number = createDoctorDto.phone_number,
                email = createDoctorDto.email,
                specialty = createDoctorDto.specialty,
                center = createDoctorDto.center
            };

            var responseStatusOk = doctorRepository.CreateDoctor(doctor);

            if (responseStatusOk == "1")
            {
                return Created("doctors", "Se ha creado correctamente el nuevo doctor");
            }
            else if (responseStatusOk == "2")
            {
                return BadRequest("La especialidad no existe");
            }
            else
            {
                return BadRequest("Something Went Wrong");
            }

        }

        [HttpGet]
        public IEnumerable<DoctorDto> GetAllStudents()
        {
            var doctors = (doctorRepository.GetAllDoctors()).Select(doctor => doctor.AsDto());
            return doctors;
        }

        [HttpGet("{id}")]
        public IActionResult GetDoctor(int id)
        {
            var particularDoctor = doctorRepository.GetDoctor(id);

            if (particularDoctor.id == 0)
            {
                return BadRequest("The user doesn't exists");
            }
            else
            {
                return Ok(particularDoctor);
            }

        }

        [HttpPut("{id}")]
        public IActionResult UpdateDoctor(int id, UpdateDoctorDto updateDoctorDto)
        {
            var existingDoctor = doctorRepository.GetDoctor(id);

            if (existingDoctor == null)
            {
                return BadRequest("The user doesn't exists");

            }

            existingDoctor.firstname = updateDoctorDto.firstName;
            existingDoctor.lastname = updateDoctorDto.lastName;
            existingDoctor.birthdate = updateDoctorDto.birthdate;
            existingDoctor.phone_number = updateDoctorDto.phone_number;
            existingDoctor.email = updateDoctorDto.email;
            existingDoctor.center = updateDoctorDto.center;

            var responseStatusOk = doctorRepository.UpdateDoctor(existingDoctor);

            if (responseStatusOk)
            {
                return Ok("Succesfully Updated");
            }
            else
            {
                return BadRequest("Something Went Wrong");
            }
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteDoctor(int id)
        {
            var responseStatusOk = doctorRepository.RemoveDoctor(id);

            if (responseStatusOk)
            {
                return Ok("Succesfully Deleted");
            }
            else
            {
                return BadRequest("Something Went Wrong");
            }
        }

    }
}
