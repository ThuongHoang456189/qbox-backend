
using QBox.Knowledges.Categories;
using QBox.Mentors.Slots;
using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace QBox.Mentors
{
    public class Mentor : FullAuditedAggregateRoot<Guid>
    {
        public string Email { get; private set; }

        public string Name { get; private set; }

        public DateTime DateOfBirth { get; private set; }

        public string PhoneNumber { get; private set; }

        public ICollection<Subject> Subjects { get; private set; }

        public ICollection<Slot> Slots { get;  private set; }
    }
}
