using AbpAngularExample.DTOs.Cars;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace AbpAngularExample.Services
{
    public interface ICarService : IGenericService<CarDto, int, PagedAndSortedResultRequestDto, CarCreateDto, CarUpdateDto>
    {
    }
}
