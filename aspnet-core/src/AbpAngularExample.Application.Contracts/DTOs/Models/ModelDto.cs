using AbpAngularExample.DTOs.Brands;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace AbpAngularExample.DTOs.Models
{
    public class ModelDto : EntityDto<int>
    {
        public string Name { get; set; }

        public int BrandID { get; set; }

        public BrandDto Brand { get; set; }
    }
}
