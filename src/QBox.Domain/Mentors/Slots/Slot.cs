using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace QBox.Mentors.Slots
{
    // Quan he composition voi Mentor?
    public class Slot : FullAuditedAggregateRoot<Guid>
    {
        public DateTime BeginTime { get; private set; }

        public DateTime EndTime { get; private set; }

        public Guid MentorId { get; private set; }

        public byte Status { get;  private set; }
    }
}
