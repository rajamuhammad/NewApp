using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Jamesthew.com.Startup))]
namespace Jamesthew.com
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
