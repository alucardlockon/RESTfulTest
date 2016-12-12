using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RestfulNews.Startup))]
namespace RestfulNews
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
