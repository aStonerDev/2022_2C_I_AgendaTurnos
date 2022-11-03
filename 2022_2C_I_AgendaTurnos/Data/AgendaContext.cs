using _2022_2C_I_AgendaTurnos.Models;
using Microsoft.EntityFrameworkCore;

namespace _2022_2C_I_AgendaTurnos.Data
{
    public class AgendaContext : DbContext
    {
#pragma warning disable CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
        public AgendaContext(DbContextOptions options) : base(options)
#pragma warning restore CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Prestacion> Prestaciones { get; set; }
        public DbSet<Profesional> Profesionales { get; set; }
        public DbSet<Turno> Turnos { get; set; }
    }
}
