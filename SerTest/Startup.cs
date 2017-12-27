using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SerTest.Startup))]
namespace SerTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
