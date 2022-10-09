using System;
using Volo.Abp.Domain.Entities;

namespace QBox.Mentors.Profiles
{
    // Cho nay phai la quan he composite with mentor
    public class MentorSkill : Entity<Guid>
    {
        public Guid MentorId { get; private set; }

        public Guid SubjectId { get; private set; }

        public string Description { get; private set; }
    }
}
