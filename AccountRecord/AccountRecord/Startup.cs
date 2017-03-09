using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AccountRecord.Startup))]
namespace AccountRecord
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
