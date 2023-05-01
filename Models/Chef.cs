using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projet_asp.Models
{
    [Table("Chefs", Schema = "Chefs1")]
    public class Chef
    {

        [Key]
        [Display(Name = "Id")]
        public int Id { get; set; }

        
        [Display(Name = "nom")]
        [Column(TypeName = "varchar(200)")]
        public string nom { get; set; }

        
        [Display(Name = "prenom")]
        [Column(TypeName = "varchar(200)")]
        public string prenom { get; set; }
        [Required]
        [Display(Name = "datenaissance")]
        [DataType(DataType.Date)]
        public DateTime datenaissance { get; set; }

        
        [Display(Name = "tel")]
        [Column(TypeName = "int")]
        public int ?tel { get; set; }

        
        [Display(Name = "specialite")]
        [Column(TypeName = "varchar(200)")]
        public string specialite { get; set; }

        
        [Display(Name = "Photo")]
        [Column(TypeName = "varchar(200)")]
        public string Photo { get; set; }
    }
}
