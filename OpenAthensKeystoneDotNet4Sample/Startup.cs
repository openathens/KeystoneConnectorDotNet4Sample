using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(OpenAthensKeystoneDotNet4Sample.Startup))]
namespace OpenAthensKeystoneDotNet4Sample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}