using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MastersNet.Startup))]
namespace MastersNet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
