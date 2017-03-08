using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyBookKeeping.Startup))]
namespace MyBookKeeping
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
