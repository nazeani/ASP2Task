using ASPTask2.DAL;
using ASPTask2.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPTask2.Controllers
{
    public class TeamController : Controller
    {
        private readonly AppDbContext _dbcontext;
        public TeamController(AppDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public IActionResult Index()
        {
            //Farmer farmer1 = new Farmer
            //{
            //    Name = "Jack",
            //    Image = "team-1.jpg",
            //    Designation = "Vegetable Producer",
            //    FBLink = "www.facebook.com/jackf1",
            //    IGLink = "www.instagram.com/jackf1",
            //    LILink = "www.linkendin.com/jackk",
            //    XLink = "www.twitter.com/jackk1"

            //};
            //Farmer farmer2 = new Farmer
            //{
            //    Name = "Alice",
            //    Image = "team-2.jpg",
            //    Designation = "Fruit Grower",
            //    FBLink = "www.facebook.com/alicee1",
            //    IGLink = "www.instagram.com/alice7",
            //    LILink = "www.linkendin.com/alicefe",
            //    XLink = "www.twitter.com/aliceetw"

            //};
            //Farmer farmer3 = new Farmer
            //{
            //    Name = "Noah",
            //    Image = "team-3.jpg",
            //    Designation = "Farmer",
            //    FBLink = "www.facebook.com/noahfb",
            //    IGLink = "www.instagram.com/noah123",
            //    LILink = "www.linkendin.com/noahfe",
            //    XLink = "www.twitter.com/noahoi"

            //};
            //List<Farmer> farmers= new List<Farmer> { farmer1, farmer2, farmer3};
            //_dbcontext.Farmers.AddRange(farmers);
            //_dbcontext.SaveChanges();
            List<Farmer> farmers = _dbcontext.Farmers.ToList();
            return View(farmers);
        }
    }
}
