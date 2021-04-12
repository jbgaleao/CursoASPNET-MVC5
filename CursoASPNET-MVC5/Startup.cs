using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CursoASPNET_MVC5.Startup))]
namespace CursoASPNET_MVC5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
