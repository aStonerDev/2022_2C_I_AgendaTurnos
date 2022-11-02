using _2022_2C_I_AgendaTurnos.Helpers;
using System.ComponentModel.DataAnnotations;

namespace _2022_2C_I_AgendaTurnos.Models
{
    public class Turno
    {
        [Key]
        [Required(ErrorMessage =ErrMsg.Requerido)]
        public int IdTurno { get; set; }

        public DateOnly Fecha { get; set; }
        public bool Confirmado { get; set; }
        public bool Activo { get; set; }
        public DateOnly FechaAlta { get; set; }
        [Required(ErrorMessage = ErrMsg.Requerido)]
        public Paciente? Paciente { get; set; }
        [Required(ErrorMessage = ErrMsg.Requerido)]
        public Profesional? Profesional { get; set; }
        [Required(ErrorMessage = ErrMsg.Requerido)]
        [RegularExpression(@"[a-zA-Z áéíóú]*", ErrorMessage = ErrMsg.SoloAlfabeto)]
        public string? DescripcionCancel { get; set; }
    }
}
