using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(TestChatApp.Startup))]

namespace TestChatApp
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}
