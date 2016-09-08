using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LaElegancia.Startup))]
namespace LaElegancia
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
