﻿using _2022_2C_I_AgendaTurnos.Helpers;
using System.ComponentModel.DataAnnotations;

namespace _2022_2C_I_AgendaTurnos.Models
{
    public class Usuario
    {
        [Key]
        [Required(ErrorMessage = ErrMsg.Requerido)]
        public int IdUsuario { get; set; }
        [EmailAddress]
        [Required(ErrorMessage = ErrMsg.Requerido)]
        public string mail { get; set; }
        public DateOnly FechaAlta { get; set; }
        [Required(ErrorMessage = ErrMsg.Requerido)]
        public string Password { get; set; }
        [Required(ErrorMessage = ErrMsg.Requerido)]
        [RegularExpression(@"[a-zA-Z áéíóú]*", ErrorMessage = ErrMsg.SoloAlfabeto)]
        public string Nombre { get; set; }
    }
}
