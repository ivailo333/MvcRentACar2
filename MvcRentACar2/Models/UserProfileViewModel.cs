using System.ComponentModel.DataAnnotations;


namespace MvcRentACar2.Models
{
    public class UserProfileViewModel
    {
        [StringLength(30,MinimumLength =5)]
        [RegularExpression(@"^[a-z0-9]*$")]
        [Required]
        public string UserName { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required]
        public string Email { get; set; }

        public string ProfileImage { get; set; }
    }
}
