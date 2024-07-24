using System.ComponentModel.DataAnnotations;

namespace Internal_Chat_App_Project.Models.dto
{
    public class RegisterModel
    {
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [Required] 
        [MaxLength(50)]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Phone]
        public string Phone { get; set; }
    }
}
