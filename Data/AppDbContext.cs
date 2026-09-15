using EscolaApi.Models;
using Microsoft.EntityFrameworkCore;

namespace EscolaApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Professor>Professores { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Modulo> Modulos { get; set; }
        public DbSet<Matricula> Matriculas { get; set; }
    }
}
