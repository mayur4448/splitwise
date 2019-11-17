using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SplitWise1.Startup))]
namespace SplitWise1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
