using RazorMultiTenancy.TenancyCore.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo1.Controllers
{
    public class HomeController : RazorMultiTenancy.Web.Controllers.HomeController
    {
        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="tenant"></param>
        public HomeController(ITenant tenant) : base(tenant) { }

        #endregion

        #region Actions

        /// <summary>
        /// Index Action (Default)
        /// </summary>
        /// <returns></returns>
        public override ActionResult Index()
        {
            this.Model.Assembly = "Demo1 Module";
            return View(this.Model);
        }

        #endregion
    }
}
