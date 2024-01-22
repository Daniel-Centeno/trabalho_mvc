using System.ComponentModel.DataAnnotations;

namespace TrabalhoTickets.Models
{
    public class Chamado
    {
        [Key]
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime Publicacao { get; set; }
        public Status Status { get; set; }
        public Usuario Funcionario { get; set; }
        public Usuario Atendente { get; set; }
        public List<Comentario> Comentarios { get; set; }
    }
}
