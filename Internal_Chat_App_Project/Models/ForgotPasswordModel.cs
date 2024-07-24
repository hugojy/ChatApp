using System.ComponentModel.DataAnnotations;

namespace Internal_Chat_App_Project.Models
{
    public class ForgotPasswordModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

    }
}
