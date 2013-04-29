using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace RazorMultiTenancy.Enums
{
    public enum Language
    {
        /// <summary>
        /// English
        /// </summary>
        [Description()]
        En,

        /// <summary>
        /// French
        /// </summary>
        [Description("French")]
        Fr,

        /// <summary>
        /// Spanish
        /// </summary>
        [Description("Spanish")]
        Es

    }
}
