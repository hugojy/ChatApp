using System;
using System.ComponentModel.DataAnnotations;

namespace Internal_Chat_App_Project.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
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
        public UserRole Role { get; set; }
    }
    public enum UserRole{
        Admin,
        User
    }
}
