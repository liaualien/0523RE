using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_0523.Startup))]
namespace _0523
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
