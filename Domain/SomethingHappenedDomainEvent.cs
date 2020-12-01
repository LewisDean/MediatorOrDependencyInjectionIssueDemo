using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class SomethingHappenedDomainEvent : ISomethingHappenedDomainEvent
    {
        public string Name { get; set; }
    }
}
