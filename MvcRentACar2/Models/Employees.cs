using System.ComponentModel.DataAnnotations;


namespace MvcRentACar2.Models
{
    public class Employees
    {
        [Key]
        public int EmployeeId { get; set; }

        [StringLength(30,MinimumLength =3)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        [Required]
        public string Fname { get; set; }

        [StringLength(30, MinimumLength = 6)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        [Required]
        public string Lname { get; set; }

        [StringLength(10,MinimumLength = 10)]
        [RegularExpression("^[0]+[0-9]*$")]
        [Required]
        public string Phone { get; set; }
    }
}
