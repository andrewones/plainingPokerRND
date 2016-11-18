using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(PlaningPokerRnd.Startup))]

namespace PlaningPokerRnd
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}
