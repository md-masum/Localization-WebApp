using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace Localization.Controllers
{
    public class LocalizationController : Controller
    {
        private readonly IStringLocalizer<LocalizationController> _localizer;

        public LocalizationController(IStringLocalizer<LocalizationController> localizer)
        {
            _localizer = localizer;
        }
        public IActionResult Index()
        {
            ViewData["Greeting"] = _localizer["Greeting"];
            return View();
        }
    }
}
