using bilet55.DAL;
using bilet55.Models;
using bilet55.View_Models.Home;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace bilet55.Controllers
{
    public class HomeController : Controller
    {

        AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM();
            homeVM.Teams = _context.Teams.ToList();
            return View(homeVM);
        }
    }
}