using Microsoft.AspNetCore.Mvc;
using TaikuriApp.Models;

namespace TaikuriApp.Controllers
{
    public class KalenteriController : Controller
    {
        public IActionResult Index()
        {
            VarausDBContext db = new VarausDBContext();
            return View();
        }
    }
}
