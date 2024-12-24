using DataAccess.Repositories;
using HealthApp.Dtos;
using HealthApp.Extensions;
using Microsoft.AspNetCore.Mvc;
using Models.Entities;
using Models.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace HealthApp.Controllers
{
    [ApiController]
    [Route("specialties")]
    public class ClinicalSpecialtyController : ControllerBase
    {
        private readonly ClinicalSpecialtyRepository clinicalSpecialtyRepository;

        public ClinicalSpecialtyController(IClinicalRepository<ClinicalSpecialty> clinicalSpecialtyRepository)
        {
            this.clinicalSpecialtyRepository = (ClinicalSpecialtyRepository)clinicalSpecialtyRepository;
        }

        [HttpPost]
        public IActionResult CreateSpecialty(CreateClinicalSpecialtyDto createClinicalSpecialtyDto)
        {
            var clinicalSpecialty = new ClinicalSpecialty
            {
                field = createClinicalSpecialtyDto.field,
                specialty = createClinicalSpecialtyDto.specialty,
                description = createClinicalSpecialtyDto.description,
            };

            var responseStatusOk = clinicalSpecialtyRepository.CreateSpecialty(clinicalSpecialty);

            if (responseStatusOk)
            {
                return Created("La especialidad {0} se ha creado correctamente", clinicalSpecialty.specialty);
            }
            else
            {
                return BadRequest("Something Went Wrong");
            }

        }

        [HttpGet]
        public IEnumerable<ClinicalSpecialtyDto> GetAllSpecialties()
        {
            var specialties = (clinicalSpecialtyRepository.GetAllSpecialties()).Select(specialty => specialty.AsDto());
            return specialties;
        }

        [HttpGet("{id}")]
        public IActionResult GetSpecialty(int id)
        {
            var particularSpecialty = clinicalSpecialtyRepository.GetSpecialty(id);

            if (particularSpecialty.id == 0)
            {
                return BadRequest("The user doesn't exists");
            }
            else
            {
                return Ok(particularSpecialty);
            }

        }

        [HttpPut("{id}")]
        public IActionResult UpdateSpecialty(int id, UpdateClinicalSpecialtyDto updateClinicalSpecialtyDto)
        {
            var existingSpecialty = clinicalSpecialtyRepository.GetSpecialty(id);

            if (existingSpecialty == null)
            {
                return BadRequest("The specialty doesn't exists");

            }

            existingSpecialty.description = updateClinicalSpecialtyDto.description;

            var responseStatusOk = clinicalSpecialtyRepository.UpdateSpecialty(existingSpecialty);

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
        public IActionResult RemoveSpecialty(int id)
        {
            var responseStatusOk = clinicalSpecialtyRepository.RemoveSpecialty(id);

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
