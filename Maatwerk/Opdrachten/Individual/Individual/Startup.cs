using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Individual.Startup))]
namespace Individual
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
