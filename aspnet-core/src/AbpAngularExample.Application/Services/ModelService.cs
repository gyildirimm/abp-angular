using AbpAngularExample.DTOs.Models;
using AbpAngularExample.Entities;
using AbpAngularExample.Permissions.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Linq;

namespace AbpAngularExample.Services
{
    public class ModelService : GenericService<Model, ModelDto, int, ModelCreateDto, ModelUpdateDto>, IModelService
    {
        private readonly IAsyncQueryableExecuter _asyncExecutor;
        private readonly IRepository<AbpAngularExample.Entities.Model, int> _repository;

        public ModelService(
                    IRepository<AbpAngularExample.Entities.Model, int> repository,
                    IAsyncQueryableExecuter asyncExecutor) : base(repository, asyncExecutor)
        {
            _asyncExecutor = asyncExecutor;
            _repository = repository;

            GetPolicyName = ModelPermission.Model.Default;
            GetListPolicyName = ModelPermission.Model.Default;
            CreatePolicyName = ModelPermission.Model.Create;
            UpdatePolicyName = ModelPermission.Model.Edit;
            DeletePolicyName = ModelPermission.Model.Delete;
        }

        public async Task<IEnumerable<ModelDto>> GetByBrandId(int brandId)
        {
            var quearyable = await _repository.WithDetailsAsync();

            quearyable = quearyable.Where(x => x.BrandID == brandId);

            IEnumerable<Model> entities = await _asyncExecutor.ToListAsync(quearyable);

            return entities.Select(MapToGetListOutputDto).AsEnumerable();
        }

    }
}
