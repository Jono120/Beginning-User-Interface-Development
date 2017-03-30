using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestWebUI.Startup))]
namespace TestWebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
