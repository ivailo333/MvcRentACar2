using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace MvcRentACar2.Models
{
    public class Cars
    {
        [Key]
        public int CarId { get; set; }

        [StringLength(40,MinimumLength = 5)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9\s]*$")]
        [Required]
        public string Marka { get; set; }

        [StringLength(11,MinimumLength = 9)]
        [RegularExpression(@"^[A-Z]+[\x20][0-9]{4,6}*[\x20][A-Z]{2}*$")]
        [Required]
        public string RegNumber { get; set; }

        [Required]
        public int ClientId { get; set; }

        [Required]
        public DateTime RentCar { get; set; }

        [Required]
        public int Km { get; set; }

        [Required]
        public int EmployeeId { get; set; }

        [Range(1,100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        [Required]
        public decimal Price { get; set; }
    }
}
