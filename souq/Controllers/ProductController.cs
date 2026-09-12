using Microsoft.AspNetCore.Mvc;
using souq.Models;

namespace souq.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(ProductVm model)
        {
            
            if (ModelState.IsValid)
            {
                SouqContext db = new SouqContext();
                Category c = new Category();
                c.Name = model.CategoryName;
                db.Products.Add(new Product
                {
                    Name = model.ProductName,
                    Price = model.ProductPrice,
                    //Quantity =(int)model.ProductQty,
                    Cat = c
                });
                db.SaveChanges();

                return RedirectToAction("Index");

            }
            return View("Index",model);
        }
    }
}
