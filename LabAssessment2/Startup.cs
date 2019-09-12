using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LabAssessment2.Startup))]
namespace LabAssessment2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
