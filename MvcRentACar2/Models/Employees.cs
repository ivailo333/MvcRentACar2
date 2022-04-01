using System.ComponentModel.DataAnnotations;


namespace MvcRentACar2.Models
{
    public class Employees
    {
        [Key]
        public int EmployeeId { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Phone { get; set; }
    }
}
