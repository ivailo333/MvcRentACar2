using System.Collections.Generic;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace MvcRentACar2.Models
{
    [DisplayName("Cars")]
    public class CarsViewModel
    {
        public string CarId { get; set; }
        public List<SelectListItem> ListCars { get; set; }
    }
}
