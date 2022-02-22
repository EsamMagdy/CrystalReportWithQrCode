using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PCR_Report.Startup))]
namespace PCR_Report
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
