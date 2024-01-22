using System.ComponentModel.DataAnnotations;

namespace TrabalhoTickets.Models
{
    public class CargoUsuario
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}
