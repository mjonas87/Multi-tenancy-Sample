using System.Collections.Generic;

namespace RazorMultiTenancy.TenancyCore.Abstract
{
    public interface IFeatureRegistry
    {
        /// <summary>
        /// Gets the features used by this tenant
        /// </summary>
        IEnumerable<IFeature> Features { get; }
    }
}
