using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AzureMLSample.Startup))]
namespace AzureMLSample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
