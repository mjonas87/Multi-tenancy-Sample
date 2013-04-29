using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMultiTenancy.TenancyCore.Abstract
{
    /// <summary>
    /// Represents a feature with subfeatures (In the context of MVC this represents a Controller)
    /// </summary>
    public interface IComplexFeature : IFeature
    {
        /// <summary>
        /// Gets the subfeatures of this feature
        /// </summary>
        IEnumerable<IFeature> SubFeatures { get; }
    }
}
