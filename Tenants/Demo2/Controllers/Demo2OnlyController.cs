using RazorMultiTenancy.TenancyCore;
using RazorMultiTenancy.TenancyCore.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tenants.Demo2.Controllers
{
    public class Demo2OnlyController : TenantAwareController
    {
        public Demo2OnlyController(ITenant tenant) : base(tenant) { }

        public ActionResult Index()
        {
            return View(this.Model);
        }

    }
}
