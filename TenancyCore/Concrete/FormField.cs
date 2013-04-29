using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RazorMultiTenancy.TenancyCore.Abstract;
using RazorMultiTenancy.Enums;

namespace RazorMultiTenancy.TenancyCore.Concrete
{
    public class FormField : IFormField
    {
        public FormField(ResourceKey resourceKey, string fieldName, int rank)
        {
            this.ResourceKey = resourceKey;
            this.FieldName = fieldName;
            this.Rank = rank;
        }

        public ResourceKey ResourceKey
        {
            get;
            protected set;
        }

        public string FieldName
        {
            get;
            protected set;
        }

        public int Rank
        {
            get;
            protected set;
        }
    }
}
