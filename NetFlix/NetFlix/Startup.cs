using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NetFlix.Startup))]
namespace NetFlix
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
