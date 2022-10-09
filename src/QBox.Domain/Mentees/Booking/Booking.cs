using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace QBox.Mentees.Booking
{
    public class Booking : FullAuditedAggregateRoot<Guid>
    {
        public Guid SlotId { get; private set; }

        public byte Status { get; private set; }

        public DateTime BookedTime { get; private set; }

        public Guid MenteeId { get; private set; }

        public ICollection<Question>
    }
}
