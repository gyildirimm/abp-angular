using AbpAngularExample.DTOs.Brands;
using AbpAngularExample.Permissions.Brand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Linq;

namespace AbpAngularExample.Services
{
    public class BrandService : GenericService<AbpAngularExample.Entities.Brand, BrandDto, int, BrandCreateDto, BrandUpdateDto>, IBrandService
    {
        private readonly IAsyncQueryableExecuter _asyncExecutor;
        private readonly IRepository<AbpAngularExample.Entities.Brand, int> _repository;

        public BrandService(
                    IRepository<AbpAngularExample.Entities.Brand, int> repository,
                    IAsyncQueryableExecuter asyncExecutor) : base(repository, asyncExecutor)
        {
            _asyncExecutor = asyncExecutor;
            _repository = repository;

            GetPolicyName = BrandPermission.Brand.Default;
            GetListPolicyName = BrandPermission.Brand.Default;
            CreatePolicyName = BrandPermission.Brand.Create;
            UpdatePolicyName = BrandPermission.Brand.Edit;
            DeletePolicyName = BrandPermission.Brand.Delete;
        }
    }
}
