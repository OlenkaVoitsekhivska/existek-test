using System.ComponentModel.DataAnnotations;
namespace API.Models

{
    public class User
    {
   
        public string Name { get; set; } = String.Empty;
        public string Password { get; set; } = String.Empty;
        [Key]
        public string Email { get; set; } = String.Empty;
    }
}