using _2022_2C_I_AgendaTurnos.Helpers;
using System.ComponentModel.DataAnnotations;

namespace _2022_2C_I_AgendaTurnos.Models
{
    public class Usuario
    {
        
        [EmailAddress]
        [Required(ErrorMessage = ErrMsg.Requerido)]
        public string? Èmail { get; set; }
        public DateOnly FechaAlta { get; set; }
        [Required(ErrorMessage = ErrMsg.Requerido)]
        public string? Password { get; set; }
        [Required(ErrorMessage = ErrMsg.Requerido)]
        [RegularExpression(@"[a-zA-Z áéíóú]*", ErrorMessage = ErrMsg.SoloAlfabeto)]
        public string? Nombre { get; set; }
    }
}
