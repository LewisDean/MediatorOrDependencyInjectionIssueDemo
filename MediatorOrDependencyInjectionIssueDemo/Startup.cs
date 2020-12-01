using MediatR;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Hosting;
using System.Diagnostics.CodeAnalysis;

[assembly: WebJobsStartup(typeof(MediatorOrDependencyInjectionIssueDemo.Startup))]

namespace MediatorOrDependencyInjectionIssueDemo
{
    [ExcludeFromCodeCoverage]
    public class Startup : IWebJobsStartup
    {
        public void Configure(IWebJobsBuilder builder)
        {
            builder.Services.AddMediatR(typeof(Domain.SomethingHappenedDomainEvent).Assembly);
        }
    }
}
