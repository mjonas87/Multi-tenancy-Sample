namespace RazorMultiTenancy.Web.App_Start
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using System.Web.Routing;
    using StructureMap;
    using RazorMultiTenancy.TenancyCore.Concrete;
    using RazorMultiTenancy.TenancyCore.Abstract;

    public class TenantConfig
    {
        public static void RegisterPlumbing(HttpContext context)
        {
            // Create a container just to pull in tenants
            var topContainer = new Container();
            topContainer.Configure(config =>
            {
                config.Scan(scanner =>
                {
                    // scan the tenants folder
                    // (For some reason just passing "Tenants" doesn't seem to work, which it should according to the docs)
                    scanner.AssembliesFromPath(Path.Combine(context.Server.MapPath("~/"), "Tenants"));

                    // pull in all the tenant types
                    scanner.AddAllTypesOf<ITenant>();
                });
            });

            // create selectors
            var tenantSelector = new DefaultTenantSelector(topContainer.GetAllInstances<ITenant>());

            foreach (var tenant in tenantSelector.Tenants)
            {
                var types = new Type[2];
                types[0] = tenant.GetType();
                types[1] = typeof(MvcApplication);
                tenant.DependencyContainer = RazorMultiTenancy.AssemblySettings.FormContainer(types, config => config.For<ITenant>().Singleton().Use(tenant));
            }

            var containerSelector = new TenantContainerResolver(tenantSelector);
            
            // clear view engines, we don't want anything other than tenant view engine
            ViewEngines.Engines.Clear();
             
            // set view engine
            var engine = new TenantViewEngine(tenantSelector);

            foreach (ITenant tenant in tenantSelector.Tenants)
	        {
                System.Web.WebPages.VirtualPathFactoryManager.RegisterVirtualPathFactory((System.Web.WebPages.IVirtualPathFactory)tenant.ViewEngine);
	        }

            ViewEngines.Engines.Add(engine);
            ViewEngines.Engines.Add(new RazorViewEngine());

            // set controller factory
            ControllerBuilder.Current.SetControllerFactory(new ContainerControllerFactory(containerSelector));
        }
    }
}