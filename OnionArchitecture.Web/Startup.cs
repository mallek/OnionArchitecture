using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OnionArchitecture.Web.Startup))]
namespace OnionArchitecture.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
