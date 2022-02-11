using AbpAngularExample.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;

namespace AbpAngularExample.Entities
{
    public class Car : AuditedAggregateRoot<int>, ISoftDelete
    {
        public string Title { get; set; }

        public virtual int ModelID { get; set; }

        public virtual Model Model { get; set; }

        public eFuelType FuelType { get; set; }

        public int Year { get; set; }

        public DateTime PurchaseDate { get; set; }

        public decimal InvoiceAmount { get; set; }

        public bool IsDeleted { get; set; }

    }
}
