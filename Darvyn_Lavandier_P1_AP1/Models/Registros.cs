using System.ComponentModel.DataAnnotations;
namespace Darvyn_Lavandier_P1_AP1.Models
{
    public class Registros
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "Solo se permiten letras")]
        public string? Persona { get; set; }

        [Required(ErrorMessage = "Este es un campo obligatorio")]
        public string? Observacion { get; set; }

        public DateTime Fecha { get; set; } = DateTime.Now;


        [Required(ErrorMessage = "El monto es obligatorio")]
        public int? Monto { get; set; }

    }
}