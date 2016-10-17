using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WORK.Startup))]
namespace WORK
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
