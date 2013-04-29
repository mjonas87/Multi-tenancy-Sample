using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;

namespace RazorMultiTenancy.Web.App_Start
{
    public class ControllerFactoryConfig
    {
        public static void RegisterControllerFactory(IControllerFactory controllerFactory)
        {
            ControllerBuilder.Current.SetControllerFactory(controllerFactory);
        }
    }
}