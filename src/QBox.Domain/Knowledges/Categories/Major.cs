using QBox.Mentees;
using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities;

namespace QBox.Knowledges.Categories
{
    public class Major : Entity<Guid>
    {
        public string Title { get; private set; }

        public string Description { get; private set; }

        public ICollection<Subject> Subjects { get; private set; }

        public ICollection<Mentee> Mentees { get; private set; }
    }
}