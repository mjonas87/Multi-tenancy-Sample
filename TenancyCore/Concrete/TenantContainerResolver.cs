namespace RazorMultiTenancy.TenancyCore.Concrete
{
    using RazorMultiTenancy.TenancyCore.Abstract;
    using RazorMultiTenancy.Utilities;
    using System.Web.Routing;
    using StructureMap;
    
    /// <summary>
    /// Module resolver that gets a dependency module/module by a tenant selector
    /// </summary>
    public class TenantContainerResolver : IContainerResolver, ITenantAware
    {
        /// <summary>
        /// Tenant selection used to resolve module from tenant
        /// </summary>
        private readonly ITenantSelector tenantSelector;

        /// <summary>
        /// Initializes a new instance of the TenantContainerResolver class that resolves a module by a tenant
        /// </summary>
        /// <param name="tenantSelector">Tenant selector used to resolve module</param>
        /// <exception cref="System.ArgumentNullException">Thrown when <paramref name="tenantSelector"/> is null</exception>
        public TenantContainerResolver(ITenantSelector tenantSelector)
        {
            Ensure.Argument.NotNull(tenantSelector, "tenantSelector");
            this.tenantSelector = tenantSelector;
        }

        #region IContainerResolver members

        /// <summary>
        /// Resolves the module of the appropriate application tenant
        /// </summary>
        /// <param name="context">Request context used to select the module</param>
        /// <returns>Module from the appropriate tenant</returns>
        public IContainer Resolve(RequestContext context)
        {
            this.Tenant = this.tenantSelector.Select(context);
            return this.Tenant.DependencyContainer;
        }

        #endregion 

        #region ITenantAware Members

        public ITenant Tenant { get; set; }

        #endregion
    }
}
