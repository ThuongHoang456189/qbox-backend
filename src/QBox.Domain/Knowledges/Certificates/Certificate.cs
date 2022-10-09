
using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace QBox.Knowledges.Certificates
{
    public class Certificate : FullAuditedAggregateRoot<Guid>
    {
        public string Issuer { get; private set; }

        public string Accomplishment { get; private set; }

        public DateTime IssuanceDate { get; private set; }

        public Guid MentorSkillId { get; private set; }

        public string DirectoryRoot { get; private set; }

        public string DirectoryStructure { get; private set; }
    }
}
