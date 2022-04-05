using System.ComponentModel.DataAnnotations;


namespace MvcRentACar2.Models
{
    public class CarRentalTime
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FullName { get; set; }
 
        [Required]
        public DateTime DateTime1 { get; set; }
    }
}
