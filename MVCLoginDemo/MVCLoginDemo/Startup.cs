using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCLoginDemo.Startup))]
namespace MVCLoginDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
