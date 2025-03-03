using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NameCraft.Models;
using NameCraft.Services;

namespace NameCraft.Controllers
{
    public class HomeController : Controller
    {
        private readonly NicknameGenerator _generator;

        public HomeController(NicknameGenerator generator) => _generator = generator;

        public IActionResult Index()
        {
            ViewBag.Nickname = _generator.Generate();
            return View();
        }

        [HttpPost]
        public IActionResult Generate(int count)
        {
            var nicknames = new List<string>();
            for (int i = 0; i < count; i++)
            {
                nicknames.Add(_generator.Generate());
            }
            ViewBag.Nicknames = nicknames;
            return View("Index");
        }
    }
}
