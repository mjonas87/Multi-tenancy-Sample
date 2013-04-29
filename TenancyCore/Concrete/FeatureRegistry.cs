using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RazorMultiTenancy.TenancyCore.Abstract;

namespace RazorMultiTenancy.TenancyCore.Concrete
{
    public class FeatureRegistry : IFeatureRegistry
    {
        private IEnumerable<IFeature> _features;

        /// <summary>
        /// Gets the features used by this tenant
        /// </summary>
        public IEnumerable<IFeature> Features
        {
            get
            {
                if (_features == null)
                {
                    _features = new List<IFeature>();
                }

                return _features;
            }

            set
            {
                _features = value;
            }
        }
    }
}
