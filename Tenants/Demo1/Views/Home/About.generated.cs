﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18033
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Demo1.Views.Home
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.5.4.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Home/About.cshtml")]
    public partial class About : System.Web.Mvc.WebViewPage<RazorMultiTenancy.BaseViewModel>
    {
        public About()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\Home\About.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";
    var viewAssembly = "Demo 1 Module";

            
            #line default
            #line hidden
WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n<head>\r\n    <meta");

WriteLiteral(" name=\"viewport\"");

WriteLiteral(" content=\"width=device-width\"");

WriteLiteral(" />\r\n    <title>");

            
            #line 11 "..\..\Views\Home\About.cshtml"
      Write(ViewRes.PageStaticText.HomeAboutTitle);

            
            #line default
            #line hidden
WriteLiteral("</title>\r\n</head>\r\n<body>\r\n    <h1></h1>\r\n    <div>\r\n");

WriteLiteral("        ");

            
            #line 16 "..\..\Views\Home\About.cshtml"
   Write(ViewRes.PageStaticText.ControllerAssembly);

            
            #line default
            #line hidden
WriteLiteral(": ");

            
            #line 16 "..\..\Views\Home\About.cshtml"
                                               Write(Model.Assembly);

            
            #line default
            #line hidden
WriteLiteral("<br />\r\n");

WriteLiteral("        ");

            
            #line 17 "..\..\Views\Home\About.cshtml"
   Write(ViewRes.PageStaticText.ViewAssembly);

            
            #line default
            #line hidden
WriteLiteral(": ");

            
            #line 17 "..\..\Views\Home\About.cshtml"
                                         Write(viewAssembly);

            
            #line default
            #line hidden
WriteLiteral("<br />\r\n    </div>\r\n</body>\r\n</html>\r\n");

        }
    }
}
#pragma warning restore 1591
