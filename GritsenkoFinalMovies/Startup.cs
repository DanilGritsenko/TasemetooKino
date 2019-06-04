using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GritsenkoFinalMovies.Startup))]
namespace GritsenkoFinalMovies
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
