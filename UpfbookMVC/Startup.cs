using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PhonebookMVC.Startup))]
namespace PhonebookMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
            ConfigureAuth(app);
        }

        private void ConfigureAuth(IAppBuilder app)
        {
            //throw new System.NotImplementedException();
        }
    }
}
