using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using VehicleInsurance.Models;

namespace VehicleInsurance.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private UserManager<ApplicationUser> userManager;

        public AdminController(UserManager<ApplicationUser> userMngr)
        {
            userManager = userMngr;

        }

        public IActionResult Index()
        {
            return View(userManager.Users);
        }
    }
}
