using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MvcRentACar2.Models
{
    public class Clients
    {
        [Key]
        public int ClientId { get; set; }

        [StringLength(30, MinimumLength = 3)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        [Required]
        public string Fname { get; set; }

        [StringLength(30, MinimumLength = 6)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        [Required]
        public string Lname { get; set; }

        [DataType(DataType.Date)]
        [Required]
        public DateTime DateOfBirth { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9\s]*$")]
        public string Address { get; set; }

        [StringLength(10, MinimumLength = 10)]
        [RegularExpression("^[0]+[0-9]*$")]
        [Required]
        public string Phone { get; set; }
    }
}
