using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCInBuiltFeatures.Startup))]
namespace MVCInBuiltFeatures
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
