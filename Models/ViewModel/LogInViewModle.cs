using System.ComponentModel.DataAnnotations;

namespace Identity1.Models.ViewModel
{
    public class LogInViewModle
    {
        [EmailAddress]
        [MaxLength(50)]
        [Required]
        [Display(Name ="Email Address")]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [MaxLength(50)]
        [Required]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
