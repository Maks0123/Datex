using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using MyDatex.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MyDatex.Controllers
{
    public class ENGController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

      [HttpPost]
      public IActionResult SetLanguage(string ganerel, string returnUrl)
       {
            Response.Cookies.Append(
               CookieRequestCultureProvider.DefaultCookieName,
               CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(ganerel)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
                );
            return LocalRedirect(returnUrl);
       }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
