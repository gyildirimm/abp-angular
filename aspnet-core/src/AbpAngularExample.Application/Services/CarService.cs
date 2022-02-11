using AbpAngularExample.DTOs.Cars;
using AbpAngularExample.Entities;
using AbpAngularExample.Permissions.Car;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Linq;

namespace AbpAngularExample.Services
{
    public class CarService : GenericService<Car, CarDto, int, CarCreateDto, CarUpdateDto>, ICarService
    {
        private readonly IAsyncQueryableExecuter _asyncExecutor;
        private readonly IRepository<AbpAngularExample.Entities.Car, int> _repository;

        public CarService(
                    IRepository<AbpAngularExample.Entities.Car, int> repository,
                    IAsyncQueryableExecuter asyncExecutor) : base(repository, asyncExecutor)
        {
            _asyncExecutor = asyncExecutor;
            _repository = repository;

            GetPolicyName = CarPermission.Car.Default;
            GetListPolicyName = CarPermission.Car.Default;
            CreatePolicyName = CarPermission.Car.Create;
            UpdatePolicyName = CarPermission.Car.Edit;
            DeletePolicyName = CarPermission.Car.Delete;
        }
    }
}
