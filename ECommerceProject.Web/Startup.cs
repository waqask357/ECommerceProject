using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ECommerceProject.Web.Startup))]
namespace ECommerceProject.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
