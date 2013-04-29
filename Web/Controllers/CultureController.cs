using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RazorMultiTenancy.Web.Enums;

namespace RazorMultiTenancy.Web.Controllers
{
    public class CultureController : Controller
    {
        //
        // GET: /Culture/

        public virtual ActionResult Change(string lang, string returnUrl)
        {
            Session[SessionKeys.Culture.ToString()] = new CultureInfo(lang);
            return Redirect(returnUrl);
        }

    }
}
