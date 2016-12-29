using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASPWebTest.Startup))]
namespace ASPWebTest
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
