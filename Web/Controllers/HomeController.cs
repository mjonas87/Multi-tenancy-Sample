namespace RazorMultiTenancy.Web.Controllers
{
    using RazorMultiTenancy.TenancyCore;
    using RazorMultiTenancy.TenancyCore.Abstract;
    using System.Web.Mvc;

    /// <summary>
    /// Home Controller (Default)
    /// </summary>
    public class HomeController : TenantAwareController
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
        public virtual ActionResult Index()
        {
            this.Model.Assembly = "Main";
            return View(this.Model);
        }

        public virtual ActionResult About()
        {
            this.Model.Assembly = "Main";
            return View(this.Model);
        }

        #endregion
    }
}