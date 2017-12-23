using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AME.UI.MVC.Startup))]
namespace AME.UI.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
