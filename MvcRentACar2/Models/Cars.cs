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
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9\s]*$")]
        [Required]
        public string City { get; set; }

        [Required]
        public DateTime RentCar1 { get; set; }

        [Required]
        public DateTime RentCar2 { get; set; }

        [Required]
        public int Km { get; set; }

        [Range(1,100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        [Required]
        public decimal Price { get; set; }
    }
}
