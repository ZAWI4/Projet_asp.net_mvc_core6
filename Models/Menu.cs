using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projet_asp.Models
{
    [Table("Menus", Schema = "Menu1")]
    public class Menu
    {

        [Key]
        [Display(Name = "Id")]
        public int Id { get; set; }
        [Required]
        [Display(Name = "nom")]
        [Column(TypeName = "varchar(200)")]
        public string nom { get; set; }
        [Required]
        [Display(Name = "prix")]
        [Column(TypeName = "float")]
        public float prix { get; set; }
      
    }
}
