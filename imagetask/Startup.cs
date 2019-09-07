using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(imagetask.Startup))]
namespace imagetask
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
