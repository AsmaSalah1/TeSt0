using System.ComponentModel.DataAnnotations;

namespace Identity1.Models.ViewModel
{
    public class RegisterViewModel

    {
        [MaxLength(20)]
        public string Name { get; set; }
        [EmailAddress]
        [MaxLength(50)]
        [Required]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        [MaxLength(50)]
        [Required]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [MaxLength(50)]
        [Required]
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }
        public string PhoneNumber { get; set; }

    }
}
