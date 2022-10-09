using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace QBox.Mentees
{
    public class Mentee : FullAuditedAggregateRoot<Guid>
    { 
        public string Email { get; private set; }

        public string Name { get; private set; }

        public DateTime DateOfBirth { get; private set; }

        public string PhoneNumber { get; private set; }
    }
}
