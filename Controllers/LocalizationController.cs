using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.Extensions.Localization;

namespace Localization.Controllers
{
    public class LocalizationController : Controller
    {
        private readonly IStringLocalizer<LocalizationController> _localizer;
        private readonly IHtmlLocalizer<LocalizationController> _htmlLocalizer;

        public LocalizationController(IStringLocalizer<LocalizationController> localizer, IHtmlLocalizer<LocalizationController> htmlLocalizer)
        {
            _localizer = localizer;
            _htmlLocalizer = htmlLocalizer;
        }
        public IActionResult Index()
        {
            ViewData["Greeting"] = _localizer["Greeting"];
            ViewData["HtmlMessage"] = _htmlLocalizer["HtmlMessage"];
            return View();
        }
    }
}
