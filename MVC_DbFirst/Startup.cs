using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_DbFirst.Startup))]
namespace MVC_DbFirst
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
