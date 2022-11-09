using _2022_2C_I_AgendaTurnos.Helpers;
using System.ComponentModel.DataAnnotations;

namespace _2022_2C_I_AgendaTurnos.Models
{
    public class Profesional : Usuario
    {
        [Key]
        [Required(ErrorMessage = ErrMsg.Requerido)]
        public int IdProfesional { get; set; }
        [Required(ErrorMessage = ErrMsg.Requerido)]
        [RegularExpression(@"[a-zA-Z áéíóú]*", ErrorMessage = ErrMsg.SoloAlfabeto)]
        public string? Apellido { get; set; }
        [Required(ErrorMessage = ErrMsg.Requerido)]
        [StringLength(10, ErrorMessage = ErrMsg.Rango)]
        public string? Telefono { get; set; }
        [Required(ErrorMessage = ErrMsg.Requerido)]
        public string? Direccion { get; set; }
        [Required(ErrorMessage = ErrMsg.Requerido)]
        public string? Matricula { get; set; }
        public List<Prestacion> Prestaciones { get; set; }
        public List<Turno> Turnos { get; set; }
    }
}
