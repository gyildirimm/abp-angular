using AbpAngularExample.DTOs.Brands;
using AbpAngularExample.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace AbpAngularExample.Services
{
    public interface IBrandService : IGenericService<BrandDto, int, PagedAndSortedResultRequestDto, BrandCreateDto, BrandUpdateDto>
    {
    }
}
