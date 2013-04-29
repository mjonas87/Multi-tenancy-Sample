namespace RazorMultiTenancy.TenancyCore.Abstract
{
    public interface IFeature
    {
        /// <summary>
        /// Gets the name of the feature used by the application
        /// </summary>
        string FeatureName { get; }
    }
}
