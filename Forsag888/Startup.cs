using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Forsag888.Startup))]
namespace Forsag888
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
