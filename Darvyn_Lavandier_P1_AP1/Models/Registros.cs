using System.ComponentModel.DataAnnotations;
namespace Darvyn_Lavandier_P1_AP1.Models
{
    public class Registros
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string? Persona { get; set; }

        [Required(ErrorMessage = "La observacion es obligatorio")]
        public string? Observacion { get; set; }

        public DateTime Fecha { get; set; } = DateTime.Now;


          [Required(ErrorMessage = "El monto es obligatorio")]
        public int? Monto { get; set; }

    }
}