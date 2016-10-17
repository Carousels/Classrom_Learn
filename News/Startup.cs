using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(News.Startup))]
namespace News
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
