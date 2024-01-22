using System.ComponentModel.DataAnnotations;

namespace TrabalhoTickets.Models
{
    public class Status
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}
