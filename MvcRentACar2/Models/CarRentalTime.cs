using System.ComponentModel.DataAnnotations;


namespace MvcRentACar2.Models
{
    public class CarRentalTime
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int ClientId { get; set; }

        [Required]
        public int EmployeeId { get; set; }

        [Required]
        public DateTime DateTime1 { get; set; }

        [Required]
        public int Duration { get; set; }
    }
}
