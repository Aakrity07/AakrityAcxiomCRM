using System.ComponentModel.DataAnnotations;

namespace AakrityAcxiom.Models
{
    public class UserLogin
    {
        
        public  string  Email { get; set; }
        
        [Required]
        public string Password { get; set; }
    }
}
