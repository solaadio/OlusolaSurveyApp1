using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(OlusolaSurveyApp1.Startup))]

namespace OlusolaSurveyApp1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}