using ASPTask2.DAL;
using ASPTask2.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPTask2.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _dbcontext;
        public ProductController(AppDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public IActionResult Index()
        {
            //OrganicProduct organicProduct1 = new OrganicProduct
            //{
            //    Name = "Organic Product",
            //    Price = 20,
            //    Image = "product-1.png"
            //};
            //OrganicProduct organicProduct2 = new OrganicProduct
            //{
            //    Name = "Fresh Product",
            //    Price = 22,
            //    Image = "product-2.png"
            //};
            //List<OrganicProduct> organicProducts = new List<OrganicProduct> { organicProduct1,organicProduct2};
            //_dbcontext.OrganicProducts.AddRange(organicProducts);
            //_dbcontext.SaveChanges();
            List<OrganicProduct> products = _dbcontext.OrganicProducts.ToList();
            return View(products);
        }
    }
}
