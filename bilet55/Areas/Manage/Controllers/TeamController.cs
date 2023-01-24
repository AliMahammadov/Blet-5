using bilet55.DAL;
using bilet55.Models;
using bilet55.View_Models.Team;
using Microsoft.AspNetCore.Mvc;

namespace bilet55.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class TeamController : Controller
    {
        public TeamController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        AppDbContext _context { get; }
        IWebHostEnvironment _env { get; }
        public IActionResult Index()
        {
            return View(_context.Teams.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CreateTeamVM create)
        {
            if (create == null)
            {
                return BadRequest();
            }

            IFormFile file = create.img;
            string fileName = Guid.NewGuid().ToString() + file.FileName;

            using (var stream = new FileStream(Path.Combine(_env.WebRootPath, "assets", "img", "team", fileName), FileMode.Create))
            {
                file.CopyTo(stream);
            };

            Team team = new Team
            {
                FullName = create.FullName,
                ImgUrl = fileName,
                Thought = create.Thought,
                Position = create.Position,
                link = create.Link

            };
            _context.Teams.Add(team);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            Team team = _context.Teams.Find(id);
            if (team == null)
            {
                return BadRequest();
            }
            _context.Teams.Remove(team);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
