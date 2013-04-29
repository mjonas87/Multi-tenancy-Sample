using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RazorMultiTenancy.Enums;

namespace RazorMultiTenancy.TenancyCore.Abstract
{
    public interface IFormField
    {
        ResourceKey ResourceKey { get; }

        string FieldName { get; }

        int Rank { get; }
    }
}
