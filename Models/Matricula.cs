using System.Text.Json.Serialization;

namespace EscolaApi.Models
{
    public class Matricula
    {
        public int Id { get; set; }
        public string NomeAluno { get; set; }
        public string EmailAluno { get; set; }
        public DateTime DataMatricula { get; set; }

        public int CursoId { get; set; }

        [JsonIgnore]
        public Curso? Curso { get; set; }
    }
}
