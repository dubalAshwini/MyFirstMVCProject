using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(myFirstMVCProject.Startup))]
namespace myFirstMVCProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
