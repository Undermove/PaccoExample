using Convey;
using Convey.Discovery.Consul;
using Microsoft.AspNetCore.Builder;

namespace Pacco.CustomPaccoService
{
    public static class Extensions
    {
        public static IConveyBuilder AddInfrastructure(this IConveyBuilder builder)
        {
            builder.AddConsul();
            
            return builder;
        }

        public static IApplicationBuilder UseApp(this IApplicationBuilder app)
        {
            app.UseConvey();
            return app;
        }
    }
}