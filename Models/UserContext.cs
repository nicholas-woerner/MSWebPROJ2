using System.ComponentModel.DataAnnotations;

namespace MSWebPROJ2.Models
{
    public class User
    {
        [Key]
        public int? ID { get; set; }
        [Required(ErrorMessage = "Please put your first name in.")]
        public string? FirstName { get; set; }
        [Required(ErrorMessage = "Please put your last name in.")]
        public string? LastName { get; set; }
        
    }
}