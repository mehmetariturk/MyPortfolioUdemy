using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace MyPortfolioUdemy.ViewComponents
{
    public class _NavbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
