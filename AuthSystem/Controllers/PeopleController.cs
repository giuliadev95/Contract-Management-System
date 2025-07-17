using System.Diagnostics;
using AuthSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace AuthSystem.Controllers
{
    public class PeopleController : Controller
    /* 
        Estende Controller, quindi può gestire:

        Richieste HTTP (GET, POST, ecc.)

        Rendering di Razor Views

        Redirezioni, Json, ecc.
    */
    {
        private readonly ILogger<PeopleController> _logger;

        public PeopleController(ILogger<PeopleController> logger)
        {
            _logger = logger;
        }

        [Authorize]
        public IActionResult Index()
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
