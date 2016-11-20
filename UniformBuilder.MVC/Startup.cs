using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UniformBuilder.MVC.Startup))]
namespace UniformBuilder.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
