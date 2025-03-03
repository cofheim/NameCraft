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
    }
}
