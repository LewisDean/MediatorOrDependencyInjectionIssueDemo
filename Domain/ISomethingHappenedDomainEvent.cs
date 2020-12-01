using MediatR;

namespace Domain
{
    public interface ISomethingHappenedDomainEvent : INotification
    {
        string Name { get; set; }
    }
}