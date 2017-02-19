using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Doshka.Startup))]
namespace Doshka
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
