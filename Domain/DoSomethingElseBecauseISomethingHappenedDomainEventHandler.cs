using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace Domain
{
    public class DoSomethingElseBecauseISomethingHappenedDomainEventHandler : INotificationHandler<ISomethingHappenedDomainEvent>
    {
        public async Task Handle(ISomethingHappenedDomainEvent notification, CancellationToken cancellationToken)
        {
            Console.WriteLine("I Something Happened");
        }
    }
}
