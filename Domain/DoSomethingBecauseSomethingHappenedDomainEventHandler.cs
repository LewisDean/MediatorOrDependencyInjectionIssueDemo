using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace Domain
{
    public class DoSomethingBecauseSomethingHappenedDomainEventHandler : INotificationHandler<SomethingHappenedDomainEvent>
    {
        public async Task Handle(SomethingHappenedDomainEvent notification, CancellationToken cancellationToken)
        {
            Console.WriteLine("Something happened");
        }
    }
}
