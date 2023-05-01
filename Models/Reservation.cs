using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projet_asp.Models
{
    [Table("Reservations", Schema = "RES1")]
    public class Reservation
    {
        [Key]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "prenom_client")]
        [Column(TypeName = "varchar(200)")]
        public string Nom_client { get; set; }

        [Required]
        [Display(Name = "prenom_client")]
        [Column(TypeName = "varchar(200)")]
        public string prenom_client { get; set; }

        [Required]
        [Display(Name = "tel_client ")]
        [Column(TypeName = "int")]
        public int tel_client { get; set; }

        [Required]
        [Display(Name = "email_client ")]
        [Column(TypeName = "varchar(200)")]
        public string email_client { get; set; }

        

        [Required]
        [Display(Name = "Date")][DataType(DataType.Date)]
        
        public DateTime Date { get; set; }

        [Required]
        [Display(Name = "Heure")]
        [Column(TypeName = "varchar(200)")]
        public string Heure { get; set; }

        [Required]
        [Display(Name = "nombre_de_personne")]
        [Column(TypeName = "int")]
        public int nombre_de_personne { get; set; }

        [Required]
        [Display(Name = "Message")]
        [Column(TypeName = "varchar(200)")]
        public string Message { get; set; }



    }
}
