using System.ComponentModel.DataAnnotations;
namespace Darvyn_Lavandier_P1_AP1.Models
{
    public class Registros
    {
        [Key]
        public int Id { get; set; }

        public string Persona { get; set; }

        public DateTime FechaCreacion { get; set; } = DateTime.Now;

        public string observacion { get; set; }

        public int monto {  get; set; } 
        
        
    }
}
