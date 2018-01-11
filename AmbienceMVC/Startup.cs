using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AmbienceMVC.Startup))]
namespace AmbienceMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
