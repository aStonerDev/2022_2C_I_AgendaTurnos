using _2022_2C_I_AgendaTurnos.Helpers;
using System.ComponentModel.DataAnnotations;

namespace _2022_2C_I_AgendaTurnos.Models
{
    public class Paciente
    {
        [Key]
        [Required(ErrorMessage = ErrMsg.Requerido)]
        public int IdPaciente { get; set; }
        [Required(ErrorMessage = ErrMsg.Requerido)]
        [RegularExpression(@"[a-zA-Z áéíóú]*", ErrorMessage = ErrMsg.SoloAlfabeto)]
        public string Nombre { get; set; }
        [Required(ErrorMessage = ErrMsg.Requerido)]
        [RegularExpression(@"[a-zA-Z áéíóú]*", ErrorMessage = ErrMsg.SoloAlfabeto)]
        public string Apellido { get; set; }
        [StringLength(8, ErrorMessage = ErrMsg.Rango)]
        [Required(ErrorMessage = ErrMsg.Requerido)]
        public string DNI { get; set; }
        [StringLength(10, ErrorMessage =ErrMsg.Rango)]
        [Required(ErrorMessage = ErrMsg.Requerido)]
        public string Telefono { get; set; }
        [Required(ErrorMessage = ErrMsg.Requerido)]
        public string Direccion { get; set; }
        public DateOnly FechaAlta { get; set; }
        [EmailAddress]
        [Required(ErrorMessage = ErrMsg.Requerido)]
        public string Email { get; set; }
        [Required(ErrorMessage = ErrMsg.Requerido)]
        public string ObraSocial { get; set; }
        public List<Turno> Turnos { get; set; }
    }
}
