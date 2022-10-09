using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace QBox.Mentees.Booking
{
    public class Document : FullAuditedAggregateRoot<Guid>
    {
        public Guid SlotId { get; private set; }

        public string DirectoryRoot { get; private set; }

        public string DirectoryStructure { get; private set; }
    }
}