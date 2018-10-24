using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Deoyaniweb.Startup))]
namespace Deoyaniweb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
