using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Konteh.GitChallenge.Test.Startup))]
namespace Konteh.GitChallenge.Test
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
