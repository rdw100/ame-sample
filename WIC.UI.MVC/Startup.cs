using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WIC.UI.MVC.Startup))]
namespace WIC.UI.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
