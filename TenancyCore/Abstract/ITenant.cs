using System.Collections.Generic;
using System.Web.Mvc;
using RazorMultiTenancy.Enums;
using StructureMap;

namespace RazorMultiTenancy.TenancyCore.Abstract
{
    public interface ITenant
    {
        /// <summary>
        /// Client/Company FeatureName
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Gets the features disabled for this tenant (Controllers and Actions)
        /// </summary>
        IFeatureRegistry DisabledFeatures { get; }

        /// <summary>
        /// Gets the list of languages that have been enabled for this tenant.
        /// </summary>
        IEnumerable<Language> Languages { get; }

        /// <summary>
        /// Gets the type of Program this tenant utilizes
        /// </summary>
        ProgramType ProgramType { get; }

        /// <summary>
        /// Gets the type of ID this tenant utilizes
        /// </summary>
        IdType IdType { get; }

        /// <summary>
        /// Enrollment Fields
        /// </summary>
        IEnumerable<IFormField> EnrollmentFields { get; }

        /// <summary>
        /// Gets the base URL paths the application should utilize
        /// </summary>
        IEnumerable<string> UrlPaths { get; }

        /// <summary>
        /// Gets the default dependency container
        /// </summary>
        /// <remarks>
        ///     The returned container should be the same as the container in the application settings.
        /// </remarks>
        IContainer DependencyContainer { get; set; }

        /// <summary>
        /// Gets the view engine used with this tenant
        /// </summary>
        IViewEngine ViewEngine { get; }
    }
}
