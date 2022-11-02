using _2022_2C_I_AgendaTurnos.Helpers;
using System.ComponentModel.DataAnnotations;

namespace _2022_2C_I_AgendaTurnos.Models
{
    public class ProfesionalPrestacion
    {
        [Key]
        [Required(ErrorMessage = ErrMsg.Requerido)]
        public int IdProfesional { get; set; }
        [Key]
        [Required(ErrorMessage = ErrMsg.Requerido)]
        public int IdPrestacion { get; set; }
        public Profesional Profesional { get; set; }
        public Prestacion Prestacion { get; set; }

    }
}
