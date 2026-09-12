using System.ComponentModel.DataAnnotations;

namespace souq.Models
{
    public class ProductVm
    {
        //[Required]
        [Display(Name ="Category Name")]
        public string CategoryName { get; set; }
        //[Required]
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }
        [Required]
        [Display(Name = "Product Price")]
        public decimal  ProductPrice { get; set; }
        [Required]
        [Display(Name = "Product Quntity")]
        public decimal ProductQty { get; set; }
    }
}
