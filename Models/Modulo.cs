using System.Text.Json.Serialization;

namespace EscolaApi.Models
{
    public class Modulo
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public int CargaHoraria{ get; set; }
        public int CursoId{ get; set; }

        [JsonIgnore]
        public Curso? Curso { get; set; }
    }
}
