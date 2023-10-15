using System.ComponentModel.DataAnnotations;

namespace MSWebPROJ2.Models
{
    public class User
    {
        [Key]
        public int? ID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        
    }
}