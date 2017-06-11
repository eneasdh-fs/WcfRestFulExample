
using Microsoft.Practices.Unity;
using Unity.Wcf;
using movie = CineMark.Movie;

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
                .RegisterType<movie.Contract, movie.Repository>();
        }
    }    
}