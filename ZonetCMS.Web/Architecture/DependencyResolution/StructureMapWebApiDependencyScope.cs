using StructureMap;
using System.Web.Http.Dependencies;

namespace ZonetCMS.Web.DependencyResolution
{
    /// <summary>
    /// The structure map web api dependency scope.
    /// </summary>
    internal class StructureMapWebApiDependencyScope : StructureMapDependencyScope, IDependencyScope
    {
        public StructureMapWebApiDependencyScope(IContainer container)
            : base(container)
        {
        }
    }
}