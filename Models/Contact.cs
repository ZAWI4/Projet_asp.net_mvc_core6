using System.ComponentModel.DataAnnotations;

namespace Projet_asp.Models
{
    public class Contact
    {
        [Key]
        public string Name { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
    }
}
