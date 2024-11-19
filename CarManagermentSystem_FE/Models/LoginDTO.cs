using System.ComponentModel.DataAnnotations;

namespace CarManagermentSystem_FE.Models
{
    public class LoginDTO
    {
        [Required]
        [StringLength(50)]
        public string UserName { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 6)]
        public string Password { get; set; }
    }
}
