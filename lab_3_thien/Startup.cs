using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lab_3_thien.Startup))]
namespace lab_3_thien
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
