using System.Web.Mvc;
using Microsoft.Practices.Unity;
using OnionArchitecture.Core.Interfaces;
using OnionArchitecture.Infrastructure;
using Unity.Mvc5;

namespace OnionArchitecture.Web
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IBloodDonorRepository, BloodDonorRepository>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}