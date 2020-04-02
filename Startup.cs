using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASP.NETMVCLambdaExpressions.Startup))]
namespace ASP.NETMVCLambdaExpressions
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
