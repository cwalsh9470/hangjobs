using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using Hangfire;

[assembly: OwinStartup(typeof(Hangjobs.Startup))]

namespace Hangjobs
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=316888
            GlobalConfiguration.Configuration.UseSqlServerStorage("HangjobsConnection")
                //.UseMsmqQueues(@"Direct=OS:localhost\hangfire-{0}")
                   ;

            app.UseHangfireDashboard();
            app.UseHangfireServer();
        }
    }
}
