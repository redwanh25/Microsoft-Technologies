using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Authen.Startup))]
namespace Authen
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
