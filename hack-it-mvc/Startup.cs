using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(hack_it_mvc.Startup))]
namespace hack_it_mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
