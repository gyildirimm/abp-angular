using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace AbpAngularExample.DTOs.Brands
{
    public class BrandDto : EntityDto<int>
    {
        public string Name { get; set; }

    }
}
