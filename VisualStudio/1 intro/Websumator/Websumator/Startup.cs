using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Websumator.Startup))]
namespace Websumator
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
