
using Microsoft.Practices.Unity;
using Unity.Wcf;
using movie = CineMark.Movie;
using prog = CineMark.Programming;
using payment = CineMark.Payment;
using product = CineMark.Products;
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
                .RegisterType<movie.Contract, movie.Repository>()
                .RegisterType<payment.Contract, payment.Repository>()
                .RegisterType<product.Contract, product.Repository>()
                .RegisterType<prog.Contract, prog.Repository>();
        }
    }    
}