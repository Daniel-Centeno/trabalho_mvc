using System.ComponentModel.DataAnnotations;

namespace TrabalhoTickets.Models
{
    public class Comentario
    {
        [Key]
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Corpo { get; set; }
        public Usuario Autor { get; set; }
        public DateTime Publicacao { get; set; }
    }
}
