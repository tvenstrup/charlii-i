using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(charlii_i.Startup))]
namespace charlii_i
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
