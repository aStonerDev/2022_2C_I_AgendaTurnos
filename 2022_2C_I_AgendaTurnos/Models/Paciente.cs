using _2022_2C_I_AgendaTurnos.Helpers;
using System.ComponentModel.DataAnnotations;

namespace _2022_2C_I_AgendaTurnos.Models
{
    public class Paciente : Usuario
    {
        [Key]
        [Required(ErrorMessage = ErrMsg.Requerido)]
        public int PacienteId { get; set; }
        [Required(ErrorMessage = ErrMsg.Requerido)]
        [RegularExpression(@"[a-zA-Z áéíóú]*", ErrorMessage = ErrMsg.SoloAlfabeto)]
        public string? Apellido { get; set; }
        [StringLength(8, ErrorMessage = ErrMsg.Rango)]
        [Required(ErrorMessage = ErrMsg.Requerido)]
        public string? DNI { get; set; }
        [StringLength(10, ErrorMessage =ErrMsg.Rango)]
        [Required(ErrorMessage = ErrMsg.Requerido)]
        public string? Telefono { get; set; }
        [Required(ErrorMessage = ErrMsg.Requerido)]
        public string? Direccion { get; set; }
        [Required(ErrorMessage = ErrMsg.Requerido)]
        public string? ObraSocial { get; set; }
        public List<Turno>? Turnos { get; set; }
    }
}
