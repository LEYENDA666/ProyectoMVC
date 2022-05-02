using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(pruebasmvc.Startup))]
namespace pruebasmvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
