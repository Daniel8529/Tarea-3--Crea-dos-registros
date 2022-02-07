using Microsoft.EntityFrameworkCore;
using Registro_Carrera_y_Estudiante.Entidades;
using Registro_Carrera_y_Estudiante.BLL;
namespace Registro_Carrera_y_Estudiante.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Carrera> Carrera { get; set; }
        public DbSet<Estudiante> Estudiante { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source= DATA\DATA.db");
        }
    }

}
