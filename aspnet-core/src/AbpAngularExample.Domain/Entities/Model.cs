using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;

namespace AbpAngularExample.Entities
{
    public class Model : AuditedAggregateRoot<int>, ISoftDelete
    {
        public string Name { get; set; }

        public bool IsDeleted { get; set; }

        public virtual int BrandID { get; set; }

        public virtual Brand Brand { get; set; }

        public virtual ICollection<Car> Cars { get; set; }
    }
}
