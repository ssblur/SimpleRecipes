using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Threading.Tasks;
using WebRecipes.Models;
using WebRecipes.Data;
using Microsoft.EntityFrameworkCore;

namespace WebRecipes.Controllers
{
    public class HomeController : Controller
    {
        private readonly WebRecipesContext _context;
        private readonly ILogger<HomeController> _logger;

        /// <summary>
        /// The Index page controller for this app.
        /// </summary>
        /// <param name="logger">A basic logger for this application</param>
        /// <param name="context">A DB context used to load recipes for the front page.</param>
        public HomeController(ILogger<HomeController> logger, WebRecipesContext context)
        {
            _logger = logger;
            _context = context;
        }

        /// <summary>
        /// The Index page for this app.
        /// Accumulates recipes on the front page, with preview images.
        /// </summary>
        /// <returns>A view containing a front page with a few recipes.</returns>
        public async Task<IActionResult> Index()
        {
            return View(await _context.Recipe.ToListAsync());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
