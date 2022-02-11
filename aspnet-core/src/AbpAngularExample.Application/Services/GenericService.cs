using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Linq;

namespace AbpAngularExample.Services
{
    public class GenericService<TEntity, TEntityDto, TKey, TCreate, TUpdate> :
            CrudAppService<TEntity, TEntityDto, TKey, PagedAndSortedResultRequestDto, TCreate, TUpdate>, 
            IGenericService<TEntityDto, TKey, PagedAndSortedResultRequestDto, TCreate, TUpdate>
        where TEntity : class, IEntity<TKey>
        where TEntityDto : IEntityDto<TKey>
    {
        private readonly IRepository<TEntity, TKey> _repository;
        private readonly IAsyncQueryableExecuter _asyncExecutor;

        public GenericService(IRepository<TEntity, TKey> repository, IAsyncQueryableExecuter asyncExecutor) : base(repository)
        {
            _repository = repository;
            _asyncExecutor = asyncExecutor;
        }

        public async Task<IEnumerable<TEntityDto>> GetFull()
        {
            var repositoryQuery = await _repository.GetQueryableAsync();

            IEnumerable<TEntity> entities = await _asyncExecutor.ToListAsync(repositoryQuery);

            return entities.Select(MapToGetListOutputDto).AsEnumerable();
        }

        public async Task<IEnumerable<TEntityDto>> GetAllDetails()
        {
            var repositoryQuery = await _repository.WithDetailsAsync();

            IEnumerable<TEntity> entities = await _asyncExecutor.ToListAsync(repositoryQuery);

            return entities.Select(MapToGetListOutputDto).AsEnumerable();
        }

        public async Task<PagedResultDto<TEntityDto>> GetDetailsByFilter(PagedAndSortedResultRequestDto filter)
        {
            var repositoryQuery = await _repository.WithDetailsAsync();

            int totalCount = await _asyncExecutor.CountAsync(repositoryQuery);

            repositoryQuery = ApplySorting(repositoryQuery, filter);

            repositoryQuery = ApplyPaging(repositoryQuery, filter);

            List<TEntity> entities = await _asyncExecutor.ToListAsync(repositoryQuery);

            return new PagedResultDto<TEntityDto>()
            {
                TotalCount = totalCount,
                Items = entities.Select(MapToGetListOutputDto).ToList()
            };
        }
    }
}
