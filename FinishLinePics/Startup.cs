using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FinishLinePics.Startup))]
namespace FinishLinePics
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
