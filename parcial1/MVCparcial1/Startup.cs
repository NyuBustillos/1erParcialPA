using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCparcial1.Startup))]
namespace MVCparcial1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
