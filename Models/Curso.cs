using System.Text.Json.Serialization;

namespace EscolaApi.Models
{
    public class Curso
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public decimal Preco { get; set; }


        public int ProfessorId { get; set; }

        [JsonIgnore]
        public Professor? Professor { get; set; }

        public ICollection<Modulo> Modulos { get; set; } = new List<Modulo>();
        public ICollection<Matricula> Matriculas{ get; set; } = new List<Matricula>();
    }
}
