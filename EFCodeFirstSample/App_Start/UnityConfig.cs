using EFCodeFirstSample.Repository;
using EFCodeFirstSample.Service;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace EFCodeFirstSample
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            container.RegisterType<IClientService, ClientService>();
            container.RegisterType<IClientRepository, ClientRepository>();
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}