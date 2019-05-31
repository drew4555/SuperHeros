using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Supers.Startup))]
namespace Supers
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
