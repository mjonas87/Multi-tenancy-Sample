using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using RazorMultiTenancy.TenancyCore.Abstract;

namespace RazorMultiTenancy.TenancyCore
{
    public abstract class TenantAwareController : Controller, ITenantAware
    {
        #region Constructor
        public TenantAwareController(ITenant tenant)
        {
            this.Model = new BaseViewModel();
            this.Model.Tenant = tenant;
        }
        #endregion
        
        #region Public Properties
        public BaseViewModel Model { get; set; }
        #endregion

        #region ITenantAware Members
        public ITenant Tenant 
        {
            get
            {
                return Model.Tenant;
            }
            set
            {
                Model.Tenant = value;
            }
        }
        #endregion
    }
}
