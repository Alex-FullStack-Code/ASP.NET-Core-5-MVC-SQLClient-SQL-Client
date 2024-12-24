
using System.ComponentModel.DataAnnotations;

namespace HealthApp.Dtos
{
    public record MedicalCenterDto(
        int id,
        string name,
        string address,
        string phoneNumber
        );

    public record CreateMedicalCenterDto(
        [Required]
        string name,
        string address,
        string phoneNumber
        );

    public record UpdateMedicalCenterDto(
        [Required]
        string name,
        string phoneNumber
        );
}
