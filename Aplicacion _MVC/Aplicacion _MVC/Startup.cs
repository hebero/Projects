using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Aplicacion__MVC.Startup))]
namespace Aplicacion__MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
