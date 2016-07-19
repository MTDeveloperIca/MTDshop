using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MTDshop.Startup))]
namespace MTDshop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
