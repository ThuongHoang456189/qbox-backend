using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace QBox.Mentees.Booking
{
    public class Question : FullAuditedAggregateRoot<Guid>
    {
        public string Content { get; private set; }

        public string Subject { get; private set; }

        public Guid BookingId { get; private set; }
    }
}
