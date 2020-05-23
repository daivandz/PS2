using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PS2.Startup))]
namespace PS2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
