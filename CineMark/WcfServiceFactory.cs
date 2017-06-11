
using Microsoft.Practices.Unity;
using Unity.Wcf;
using m = CineMark.Movie;
using p = CineMark.Programming;
namespace CineMark
{
	public class WcfServiceFactory : UnityServiceHostFactory
    {
        protected override void ConfigureContainer(IUnityContainer container)
        {
			// register all your components with the container here
            // container
            //    .RegisterType<IService1, Service1>()
            //    .RegisterType<DataContext>(new HierarchicalLifetimeManager());

            container.RegisterType<Entities, Entities>()
                .RegisterType<m.Contract, m.Repository>()
                .RegisterType<p.Contract, p.Repository>();
        }
    }    
}