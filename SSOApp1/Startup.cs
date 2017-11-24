
using Microsoft.Owin;
using Owin;
[assembly:OwinStartupAttribute(typeof(SSOApp1.Startup))]
namespace SSOApp1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}