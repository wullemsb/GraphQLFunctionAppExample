using System;
using System.IO;
using System.Threading.Tasks;
using HotChocolate.AzureFunctions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace GraphQLFunctionApp
{
    public class GraphQLFunction
    {
        [FunctionName("GraphQLHttpFunction")]
        public Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = "graphql/{**slug}")]
            HttpRequest request,
            [GraphQL]
            IGraphQLRequestExecutor executor)
            => executor.ExecuteAsync(request);
    }
}
