using Microsoft.AspNetCore.Mvc;
using registration_form.Models.Home;

namespace registration_form.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(FormModel? formModel)
        {
            return View(formModel);
        }
    }
}