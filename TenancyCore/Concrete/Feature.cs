namespace RazorMultiTenancy.TenancyCore.Concrete
{
    using RazorMultiTenancy.TenancyCore.Abstract;

    public class Feature : IFeature
    {
        public Feature(string featureName)
        {
            this.FeatureName = featureName;
        }

        public string FeatureName
        {
            get;
            private set;
        }
    }
}

