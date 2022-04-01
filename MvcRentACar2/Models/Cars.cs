using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace MvcRentACar2.Models
{
    public class Cars
    {
        [Key]
        public int CarId { get; set; }
        public string Marka { get; set; }
        public string RegNumber { get; set; }
        public int ClientId { get; set; }
        public DateTime RentCar { get; set; }
        public int Km { get; set; }
        public int EmployeeId { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
    }
}
