using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProyectoX.Startup))]
namespace ProyectoX
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
