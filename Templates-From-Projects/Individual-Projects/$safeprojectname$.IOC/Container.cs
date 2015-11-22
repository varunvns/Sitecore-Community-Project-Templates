using Castle.Windsor;
using Sitecore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$.IOC
{
    public class Container
    {
        protected static readonly IWindsorContainer container = new WindsorContainer();

        public static void Initialize(Action<IWindsorContainer> initialization)
        {
            initialization.Invoke(container);
        }

        public static T Resolve<T>()
        {
            return container.Resolve<T>();
        }

        public static void Release(object obj)
        {
            if (container == null || obj == null) return;
            container.Release(obj);
        }
    }
}
