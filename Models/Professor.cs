namespace EscolaApi.Models
{
    public class Professor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Especialidade { get; set; }

        public ICollection<Curso>? Cursos { get; set; } = new List<Curso>();
    }
}
