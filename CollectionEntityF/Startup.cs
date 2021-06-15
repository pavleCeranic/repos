using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CollectionEntityF.Startup))]
namespace CollectionEntityF
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
