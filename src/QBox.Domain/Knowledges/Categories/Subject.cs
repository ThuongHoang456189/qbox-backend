using System;
using Volo.Abp.Domain.Entities;

namespace QBox.Knowledges.Categories
{
    public class Subject : Entity<Guid>
    {
        public string Title { get; private set; }

        public string Description { get; private set; }

        public Guid MajorId { get; private set; }
    }
}