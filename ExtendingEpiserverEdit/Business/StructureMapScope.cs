using System;
using System.Collections.Generic;
using System.Linq;

using StructureMap;

namespace ExtendingEpiserverEdit.Business
{
    public class StructureMapScope
    {
        private readonly IContainer container;

        public StructureMapScope(IContainer container)
        {
            if (container == null) throw new ArgumentNullException("container cannot be null");
            this.container = container;
        }

        public object GetService(Type serviceType)
        {
            if (serviceType == null) return null;
            if (serviceType.IsAbstract || serviceType.IsInterface) return container.TryGetInstance(serviceType);

            return container.GetInstance(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return container.GetAllInstances(serviceType).Cast<object>();
        }

        public void Dispose()
        {
            this.container.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}