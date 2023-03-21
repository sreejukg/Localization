﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Localization;

namespace LocalizationSample.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        public IActionResult OnGetLoadArabic()
        {
            Response.Cookies.Append(".AspNetCore.Culture", "c=ar|uic=ar", new CookieOptions { Expires=DateTime.Now.AddDays(1)});
            return Redirect("/");
        }
        public IActionResult OnGetLoadFrench()
        {
            Response.Cookies.Append(".AspNetCore.Culture", "c=fr|uic=fr", new CookieOptions { Expires = DateTime.Now.AddDays(1) });
            return Redirect("/");
        }
        public IActionResult OnGetLoadEnglish()
        {
            Response.Cookies.Append(".AspNetCore.Culture", "c=en|uic=en", new CookieOptions { Expires = DateTime.Now.AddDays(1) });
            return Redirect("/");
        }
    }
}