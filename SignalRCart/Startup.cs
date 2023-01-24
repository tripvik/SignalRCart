using Microsoft.AspNet.SignalR;
using Microsoft.Owin;
using Owin;
using System;
using System.Threading.Tasks;

[assembly: OwinStartup(typeof(SignalRCart.Startup))]

namespace SignalRCart
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var hubConfiguration = new HubConfiguration
            {
                EnableDetailedErrors = true
            };
            app.MapSignalR(hubConfiguration);
        }
    }
}
