using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using souq.Models;

namespace souq.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        SouqContext db = new SouqContext();

        public IActionResult Index()
        {
            IndexVM result = new IndexVM();
            result.Categories = db.Categories.ToList();
            result.Products = db.Products.ToList();
            result.Reviews = db.Reviews.ToList();
            result.LatestProducts = db.Products.OrderByDescending(x => x.EntryDate).Take(4).ToList();

            return View(result);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Categories()
        {
            var cats= db.Categories.ToList();
            ViewBag.isAdmin = true;

            return View(cats);
        }

        public IActionResult Products(int id)
        {
                
            var Products = db.Products.Where(x=> x.Id == id).ToList();
            return View(Products);
        }

        public IActionResult CurrentProduct(int id)
        {

            var Product = db.Products.Include(x=>x.Cat).FirstOrDefault(x => x.Id == id);
            return View(Product);
        }
        [HttpGet]

        [HttpGet]
        public IActionResult ProductSearch(string xname)
        {
            var Products = new List<Product>();

            if (string.IsNullOrWhiteSpace(xname))
            {
                Products = db.Products.ToList();
            }
            else
            {
                Products = db.Products
                    .Where(x => x.Name.Contains(xname))
                    .ToList();
            }

            return View(Products);
        }

        [HttpPost]
        [Route("SendReview")]
        public IActionResult SendReview(ReviewVM model)
        {
            db.Reviews.Add(new Review { Name=model.Name, Email=model.Email,Subject=model.Subject, Description=model.Description});
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Carts()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
