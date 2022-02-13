using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace AbpAngularExample.Services
{
    public interface IGenericService<TDto, TKey, TGetListInput, TCreateInput, TUpdateInput> 
        : ICrudAppService<TDto, TKey, TGetListInput, TCreateInput, TUpdateInput>
        where TDto : IEntityDto<TKey>
    {
        Task<IEnumerable<TDto>> GetFull();

        Task<IEnumerable<TDto>> GetAllDetails();

        Task<PagedResultDto<TDto>> GetDetailsByFilter(PagedAndSortedResultRequestDto filter);
    }
}
