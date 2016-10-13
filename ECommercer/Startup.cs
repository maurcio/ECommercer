using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ECommercer.Startup))]
namespace ECommercer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
