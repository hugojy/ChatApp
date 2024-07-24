using System.ComponentModel.DataAnnotations;

namespace Internal_Chat_App_Project.Models
{
    public class ResetPasswordModel
    {
        [Required]
        public string Token { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string NewPassword { get; set; }
    }
}
