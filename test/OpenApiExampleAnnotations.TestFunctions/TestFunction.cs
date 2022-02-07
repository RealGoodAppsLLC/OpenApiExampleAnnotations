using System.Collections.Generic;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Attributes;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Enums;
using Microsoft.Extensions.Logging;
using OpenApiExampleAnnotations.TestModels;
using RealGoodApps.OpenApiExampleAnnotations;

namespace OpenApiExampleAnnotations.TestFunctions
{
    public sealed class TestFunction
    {
        [OpenApiOperation("TestFunction", "Tests", Summary = "Do a thing", Description = "Do a thing.", Visibility = OpenApiVisibilityType.Important)]
        [OpenApiResponseWithBody(HttpStatusCode.Created, "application/json", typeof(TestResponseModel), Summary = "Created", Description = "The thing has happened.", Example = typeof(ExampleGenerator<TestResponseModel>))]
        [FunctionName("TestFunction")]
        public async Task<IActionResult> RunAsync(
            [HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = "tests")]
            HttpRequest req,
            ILogger log,
            CancellationToken cancellationToken)
        {
            // Simulate some async.
            await Task.Delay(500, cancellationToken);

            return new CreatedResult($"/api/tests", new TestResponseModel
            {
                // SomeStrings = new List<string>
                // {
                //     "Hello",
                //     "World",
                // },
            });
        }
    }
}
