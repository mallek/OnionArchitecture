using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using OnionArchitecture.Infrastructure;

namespace OnionArchitecture.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            UnityConfig.RegisterComponents();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            BloodDonorInitalizeDb db = new BloodDonorInitalizeDb();
            System.Data.Entity.Database.SetInitializer(db);
        }
    }
}
