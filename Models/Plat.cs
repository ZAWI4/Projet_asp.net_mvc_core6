using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projet_asp.Models
{
    [Table("Plats", Schema = "Plats1")]
    public class Plat
    {

        [Key]
        [Display(Name = "Id")]
        public int Id { get; set; }
        [Required]  
        [Display(Name = "lib")]
        [Column(TypeName = "varchar(200)")]
        public string lib { get; set; }

        public int id_Menu { get; set; }
        [ForeignKey("id_Menu")]
        public Menu? Menu { get; set; }
    }
}
