using System.Threading.Tasks;
using Convey;
using Convey.WebApi;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace Pacco.CustomPaccoService
{
    public class Program
    {
        public static async Task Main(string[] args) 
            => await WebHost.CreateDefaultBuilder(args)
                .ConfigureServices(services => services
                    .AddConvey()
                    .AddWebApi()
                    .AddInfrastructure()
                    .Build()
                )
                .Configure(app => app
                    .UseApp())
                .Build()
                .RunAsync();
    }
}