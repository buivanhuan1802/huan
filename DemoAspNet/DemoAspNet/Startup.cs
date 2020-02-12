using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoAspNet.Startup))]
namespace DemoAspNet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
