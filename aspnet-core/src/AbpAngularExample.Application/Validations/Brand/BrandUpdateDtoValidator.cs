using AbpAngularExample.DTOs.Brands;
using FluentValidation;

namespace AbpAngularExample.Validations.Brand
{
    public class BrandUpdateDtoValidator : AbstractValidator<BrandUpdateDto>
    {
        public BrandUpdateDtoValidator()
        {
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.Id).NotEmpty();
        }
    }
}
