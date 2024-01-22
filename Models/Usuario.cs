using System.ComponentModel.DataAnnotations;

namespace TrabalhoTickets.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateOnly Nascimento { get; set; }
        public CargoUsuario Cargo { get; set; }
    }
}
