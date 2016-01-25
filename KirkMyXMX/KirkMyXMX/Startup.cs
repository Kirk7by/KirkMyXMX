using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KirkMyXMX.Startup))]
namespace KirkMyXMX
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
