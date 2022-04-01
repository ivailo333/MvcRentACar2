using System.ComponentModel.DataAnnotations;


namespace MvcRentACar2.Models
{
    public class CarRentalTime
    {
        [Key]
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime DateTime1 { get; set; }
        public int Duration { get; set; }
    }
}
