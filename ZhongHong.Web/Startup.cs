using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ZhongHong.Web.Startup))]
namespace ZhongHong.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
