using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMultiTenancy.TenancyCore.Abstract
{
    public interface ITenantAware
    {
        ITenant Tenant { get; set; }
    }
}
