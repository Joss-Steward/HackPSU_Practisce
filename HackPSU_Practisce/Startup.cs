using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HackPSU_Practisce.Startup))]
namespace HackPSU_Practisce
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
