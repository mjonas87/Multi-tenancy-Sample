namespace Tenants.Demo2
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
    public class Demo2Tenant : AbstractTenant
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Demo2Tenant()
        {
            //Initialize Disabled Features
            DisabledFeatures = new FeatureRegistry()
            {
                Features = new List<IFeature>() 
                { 
                    //Controller
                    new ComplexFeature("Store", new List<IFeature> 
                    { 
                        //Actions
                        new Feature("Buy")
                    })
                }
            };

            //Initialize Enrollment Fields
            EnrollmentFields = new List<IFormField>()
            {
                new FormField(ResourceKey.FirstName, "FirstName", 1),
                new FormField(ResourceKey.LastName, "LastName", 2),
                new FormField(ResourceKey.BirthDate, "BirthDate", 3),
                new FormField(ResourceKey.Phone, "Phone", 4)
            };

            Name = "Demo2";
            Languages = new List<Language>() { Language.En };
            UrlPaths = new[] { "http://localhost:3456/" };
        }
    }
}
