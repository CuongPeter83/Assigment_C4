using Assignment.Models.Data;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Assignment.Models.ViewModel
{
    public class ProductViewModel
    {
        public Product Product { get; set; }
        public IEnumerable<SelectListItem> SelectListCapacity { get; set; }
        public IEnumerable<SelectListItem> SelectListCatagory { get; set; }
        public IEnumerable<SelectListItem> SelectListSupplier { get; set; }
    }
}
