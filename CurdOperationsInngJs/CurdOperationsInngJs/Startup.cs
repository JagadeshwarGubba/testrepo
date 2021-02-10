using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CurdOperationsInngJs.Startup))]
namespace CurdOperationsInngJs
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
