using AbpAngularExample.DTOs.Models;
using AbpAngularExample.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace AbpAngularExample.Services
{
    public interface IModelService : IGenericService<ModelDto, int, PagedAndSortedResultRequestDto, ModelCreateDto, ModelUpdateDto>
    {
    }
}
