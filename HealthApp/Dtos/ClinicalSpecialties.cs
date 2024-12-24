
using System.ComponentModel.DataAnnotations;
namespace HealthApp.Dtos
{
    public record ClinicalSpecialtyDto(
        int id,
        string field,
        string specialty,
        string description
        );

    public record CreateClinicalSpecialtyDto(
        [Required]
        string field,
        string specialty,
        string description
        );

    public record UpdateClinicalSpecialtyDto(
        [Required]
        string description
        );
}
