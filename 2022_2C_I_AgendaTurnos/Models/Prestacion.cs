using _2022_2C_I_AgendaTurnos.Helpers;
using System.ComponentModel.DataAnnotations;

namespace _2022_2C_I_AgendaTurnos.Models
{
    public class Prestacion
    {
        [Key]
        [Required(ErrorMessage = ErrMsg.Requerido)]
        public int IdPrestacion { get; set; }
        [Required(ErrorMessage = ErrMsg.Requerido)]
        [RegularExpression(@"[a-zA-Z áéíóú]*", ErrorMessage = ErrMsg.SoloAlfabeto)]
        public string Nombre { get; set; }
        [Required(ErrorMessage = ErrMsg.Requerido)]
        [RegularExpression(@"[a-zA-Z áéíóú]*", ErrorMessage = ErrMsg.SoloAlfabeto)]
        public string Descripcion { get; set; }
        public DateTime Duracion { get; set; }
        public double Precio { get; set; }
        public List<ProfesionalPrestacion> ProfesionalesPrestaciones { get; set; }
        public List<Paciente> Pacientes { get; set; }
    }
}
