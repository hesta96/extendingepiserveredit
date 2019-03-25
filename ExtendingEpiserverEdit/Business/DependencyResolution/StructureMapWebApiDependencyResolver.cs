namespace ExtendingEpiserverEdit.Business.DependencyResolution
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Http.Dependencies;
    using StructureMap;

    public class StructureMapWebApiDependencyResolver : IDependencyResolver
    {
        private readonly IContainer container;

        public StructureMapWebApiDependencyResolver(IContainer container)
        {
            this.container = container;
        }

        public IDependencyScope BeginScope()
        {
            var childContainer = this.container.GetNestedContainer();

            return new StructureMapWebApiDependencyResolver(childContainer);
        }

        public object GetService(Type serviceType)
        {
            if (serviceType.IsInterface || serviceType.IsAbstract)
            {
                return this.container.TryGetInstance(serviceType);
            }

            return this.container.GetInstance(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return this.container.GetAllInstances(serviceType).Cast<object>();
        }

        public void Dispose()
        {
            this.container.Dispose();
        }
    }
}