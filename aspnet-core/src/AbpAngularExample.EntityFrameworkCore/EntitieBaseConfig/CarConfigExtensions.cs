using AbpAngularExample.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbpAngularExample.EntitieBaseConfig
{
    internal static class CarConfigExtensions
    {
        internal static void SetCarBaseConfig(this ModelBuilder builder)
        {
            builder.Entity<Car>(c =>
            {
                c.Property(e => e.InvoiceAmount).HasColumnType("decimal(18,2)");
            });
        }
    }
}
