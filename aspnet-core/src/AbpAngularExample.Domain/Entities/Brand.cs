using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;

namespace AbpAngularExample.Entities
{
    public class Brand : AuditedAggregateRoot<int>, ISoftDelete
    {
        public string Name { get; set; }

        public virtual ICollection<Model> Models { get; set; }
        public bool IsDeleted { get; set; }
    }
}
