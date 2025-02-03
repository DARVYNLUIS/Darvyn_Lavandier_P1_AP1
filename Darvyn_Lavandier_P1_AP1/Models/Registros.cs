using System.ComponentModel.DataAnnotations;
namespace DarvynLuisLavandier_P1_AP1.Models
{
    public class Registros
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string? Nombres { get; set; }


    }
}
