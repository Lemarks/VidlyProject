using System.ComponentModel.DataAnnotations;

namespace VidlyProject.Models
{
    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}