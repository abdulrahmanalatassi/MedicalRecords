using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebFromsDemo.Startup))]
namespace WebFromsDemo
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
