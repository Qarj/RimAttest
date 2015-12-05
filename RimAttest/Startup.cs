using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RimAttest.Startup))]
namespace RimAttest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
