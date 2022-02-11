using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace AbpAngularExample.DTOs.Models
{
    public class ModelUpdateDto : EntityDto<int>
    {
        public string Name { get; set; }

        public int BrandId { get; set; }
    }
}
