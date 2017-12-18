using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Santavolpe.Startup))]
namespace Santavolpe
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
