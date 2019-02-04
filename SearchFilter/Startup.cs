using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SearchFilter.Startup))]
namespace SearchFilter
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
