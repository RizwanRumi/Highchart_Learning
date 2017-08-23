using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoChart.Startup))]
namespace DemoChart
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
