using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bob_Tutorials_Web.Startup))]
namespace Bob_Tutorials_Web
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
