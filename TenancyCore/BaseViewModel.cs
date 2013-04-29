using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RazorMultiTenancy.TenancyCore.Abstract;

namespace RazorMultiTenancy
{
    public class BaseViewModel : ITenantAware
    {
        public ITenant Tenant { get; set; }
        public string CurrentUser { get; set; }

        //This is only for demonstration purposes
        public string Assembly { get; set; }
    }
}