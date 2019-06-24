using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Single.Startup))]
namespace Single
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
            ConfigureAuth(app);


        }
    }
}
