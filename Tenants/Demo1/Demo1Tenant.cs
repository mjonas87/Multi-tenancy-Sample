namespace Tenants.Demo1
{
    using RazorMultiTenancy.Enums;
    using RazorMultiTenancy.TenancyCore.Abstract;
    using RazorMultiTenancy.TenancyCore.Concrete;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    
    /// <summary>
    /// Demo Tenant
    /// </summary>
    public class Demo1Tenant : AbstractTenant
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Demo1Tenant()
        {
            //Initialize Disabled Features
            DisabledFeatures = new FeatureRegistry()
            {
                Features = new List<IFeature>() 
                { 
                    //Controller
                    new Feature("Store")    //Entire controller is disabled
                }
            };

            //Initialize Enrollment Fields
            EnrollmentFields = new List<IFormField>()
            {
                new FormField(ResourceKey.FirstName, "FirstName", 1),
                new FormField(ResourceKey.LastName, "LastName", 2),
            };

            Name = "Demo1";
            Languages = new List<Language>() { Language.En , Language.Fr};
            UrlPaths = new[] { "http://localhost:3455/" };
        }
    }
}
