using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Net_Framework_Identity.Startup))]
namespace Net_Framework_Identity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
