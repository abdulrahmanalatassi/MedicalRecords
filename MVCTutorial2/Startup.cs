using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCTutorial2.Startup))]
namespace MVCTutorial2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
