using _2022_2C_I_AgendaTurnos.Helpers;
using System.ComponentModel.DataAnnotations;

namespace _2022_2C_I_AgendaTurnos.Models
{
    public class Turno
    {
        [Key]
        [Required(ErrorMessage =ErrMsg.Requerido)]
        public int IdTurno { get; set; }
        [RegularExpression(@"^(((0[13-9]|1[012])[-/]?(0[1-9]|[12][0-9]|30)|(0[13578]|1[02])[-/]?31|02[-/]?(0[1-9]|1[0-9]|2[0-8]))[-/]?[0-9]{4}|02[-/]?29[-/]?([0-9]{2}(([2468][048]|[02468][48])|[13579][26])|([13579][26]|[02468][048]|0[0-9]|1[0-6])00))$", ErrorMessage = ErrMsg.Requerido)]
        public string? Fecha { get; set; }
        public bool Confirmado { get; set; }
        public bool Activo { get; set; }
        [RegularExpression(@"^(((0[13-9]|1[012])[-/]?(0[1-9]|[12][0-9]|30)|(0[13578]|1[02])[-/]?31|02[-/]?(0[1-9]|1[0-9]|2[0-8]))[-/]?[0-9]{4}|02[-/]?29[-/]?([0-9]{2}(([2468][048]|[02468][48])|[13579][26])|([13579][26]|[02468][048]|0[0-9]|1[0-6])00))$", ErrorMessage = ErrMsg.Requerido)]
        public string? FechaAlta { get; set; }
        [Required(ErrorMessage = ErrMsg.Requerido)]
        public int PacienteId { get; set; }
        [Required(ErrorMessage = ErrMsg.Requerido)]
        public Paciente? Paciente { get; set; }
        [Required(ErrorMessage = ErrMsg.Requerido)]
        public Profesional? Profesional { get; set; }
        [Required(ErrorMessage = ErrMsg.Requerido)]
        public int ProfesionalId { get; set; }
        [Required(ErrorMessage = ErrMsg.Requerido)]
        [RegularExpression(@"[a-zA-Z áéíóú]*", ErrorMessage = ErrMsg.SoloAlfabeto)]
        public string? DescripcionCancel { get; set; }
    }
}
