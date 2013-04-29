namespace RazorMultiTenancy
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using StructureMap;
    using RazorMultiTenancy.TenancyCore.Concrete;

    /// <summary>
    /// Assembly view path settings for compilation
    /// </summary>
    public static class AssemblySettings
    {
        public struct AssemblyViewPath
        {
            public Assembly Assembly;
            public string ViewPath;
        }

        /// <summary>
        /// Embedded assembly view paths stored with corresponding assembly
        /// </summary>
        /// <remarks>Array parameter should be in order of selectivity (primary first)</remarks>
        public static IEnumerable<AssemblyViewPath> GetAssemblyViewPaths(Type[] types)
        {
            var avps = new AssemblyViewPath[types.Length];
            
            for(int i = 0; i < avps.Length; i++)
            {
                avps[i] = new AssemblyViewPath() {Assembly = types[i].Assembly, ViewPath = types[i].Namespace};
            }

            return avps;
        }

        /// <summary>
        /// Forms a dependency module
        /// </summary>
        /// <param name="customExpression">Custom configuration expression</param>
        /// <returns>Module constructed for the application</returns>
        public static IContainer FormContainer(Type[] types, Action<ConfigurationExpression> customExpression = null)
        {
            var container = new Container();

            container.Configure(config =>
            {
                config.Scan(scanner =>
                {
                    scanner.Convention<ControllerConvention>();
                    AssemblySettings.GetAssemblyViewPaths(types).Each(avp => scanner.Assembly(avp.Assembly));
                });

                if (customExpression != null)
                    customExpression(config);
            });

            return container;
        }
    }
}