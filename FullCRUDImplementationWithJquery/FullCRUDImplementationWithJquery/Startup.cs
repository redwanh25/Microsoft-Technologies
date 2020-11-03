using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FullCRUDImplementationWithJquery.Startup))]
namespace FullCRUDImplementationWithJquery
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
