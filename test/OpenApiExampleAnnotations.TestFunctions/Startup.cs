using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using OpenApiExampleAnnotations.TestFunctions;

[assembly: FunctionsStartup(typeof(Startup))]

namespace OpenApiExampleAnnotations.TestFunctions
{
    public sealed class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
        }
    }
}
