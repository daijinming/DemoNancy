using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoNancy.Startup))]
namespace DemoNancy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            app.UseNancy();
        }
    }
}
