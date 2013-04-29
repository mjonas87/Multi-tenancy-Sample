using RazorMultiTenancy.TenancyCore;
using RazorMultiTenancy.TenancyCore.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RazorMultiTenancy.Web.Controllers
{
    public class StoreController : TenantAwareController
    {
         #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="tenant"></param>
        public StoreController(ITenant tenant) : base(tenant) { }

        #endregion  

        #region Actions

        public virtual ActionResult Index()
        {
            this.Model.Assembly = "Main";
            return View(this.Model);
        }

        public virtual ActionResult Buy()
        {
            this.Model.Assembly = "Main";
            return View(this.Model);
        }

        #endregion
    }
}
