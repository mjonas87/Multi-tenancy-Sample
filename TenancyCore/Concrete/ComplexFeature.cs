namespace RazorMultiTenancy.TenancyCore.Concrete
{
    using System.Collections.Generic;
    using RazorMultiTenancy.TenancyCore.Abstract;
    
    /// <summary>
    /// Complex Feature
    /// </summary>
    /// <remarks>In an MVC context, this is a Controller.</remarks>
    public class ComplexFeature : IComplexFeature
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="featureName"></param>
        /// <param name="subFeatures"></param>
        public ComplexFeature(string featureName, IEnumerable<IFeature> subFeatures)
        {
            this.FeatureName = featureName;
            this.SubFeatures = subFeatures;
        }

        /// <summary>
        /// Sub Features
        /// </summary>
        /// <remarks>In an MVC context, these are Actions.</remarks>
        public IEnumerable<IFeature> SubFeatures
        {
            get;
            private set;
        }

        /// <summary>
        /// Feature Name
        /// </summary>
        public string FeatureName
        {
            get;
            private set;
        }
    }
}
