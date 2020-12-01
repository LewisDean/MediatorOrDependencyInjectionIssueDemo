using Domain;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using System.Threading.Tasks;

namespace MediatorOrDependencyInjectionIssueDemo
{
    public class Function1
    {
        private readonly IMediator _mediatr;

        public Function1(IMediator mediatr)
        {
            _mediatr = mediatr;
        }

        [FunctionName("Function1")]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req)
        {
            await _mediatr.Publish(new SomethingHappenedDomainEvent
            {
                Name = "TestEvent"
            });

            return new OkResult();
        }
    }
}
