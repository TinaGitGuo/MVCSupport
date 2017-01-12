using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCSupport.Startup))]
namespace MVCSupport
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
