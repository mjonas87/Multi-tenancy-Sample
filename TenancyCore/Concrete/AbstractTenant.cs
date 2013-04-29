using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using RazorMultiTenancy.TenancyCore.Abstract;
using RazorMultiTenancy.Enums;
using StructureMap;

namespace RazorMultiTenancy.TenancyCore.Concrete
{
    public class AbstractTenant : ITenant
    {
        private IViewEngine _viewEngine;

        #region ITenant Members

        /// <summary>
        /// Gets the name of the application (company name)
        /// </summary>
        public string Name { get; protected set; }

        /// <summary>
        /// Gets the features disabled for this tenant.  All features are implicitly enabled, unless explicitly disabled.
        /// </summary>
        public IFeatureRegistry DisabledFeatures { get; protected set; }

        /// <summary>
        /// Gets the list of languages that have been enabled for this tenant.
        /// </summary>
        public IEnumerable<Language> Languages { get; protected set; }

        /// <summary>
        /// Gets the type of Program this tenant utilizes
        /// </summary>
        public ProgramType ProgramType { get; protected set; }

        /// <summary>
        /// Gets the type of ID this tenant utilizes
        /// </summary>
        public IdType IdType { get; protected set; }

        /// <summary>
        /// Enrollment Fields
        /// </summary>
        public IEnumerable<IFormField> EnrollmentFields { get; protected set; }

        /// <summary>
        /// Gets the base URL paths the applicaiton should utilize
        /// </summary>
        public IEnumerable<string> UrlPaths { get; protected set; }

        /// <summary>
        /// Gets the default dependency container
        /// </summary>
        /// <value></value>
        /// <remarks>
        /// The returned container should be the same as the
        /// container as the container in the application settings
        /// </remarks>
        public IContainer DependencyContainer { get; set; }


        /// <summary>
        /// Gets the view engine used with this tenant
        /// </summary>
        public IViewEngine ViewEngine
        {
            get
            {
                if (_viewEngine == null)
                {
                    _viewEngine = DetermineViewEngine();
                }

                return _viewEngine;
            }
        }

        /// <summary>
        /// Gets the view engine based on the assembly containing the tenant
        /// </summary>
        /// <returns>View engine for the application tenant</returns>
        protected virtual IViewEngine DetermineViewEngine()
        {
            return new RazorGenerator.Mvc.PrecompiledMvcEngine(this.GetType().Assembly);
        }

        #endregion
    }
}
