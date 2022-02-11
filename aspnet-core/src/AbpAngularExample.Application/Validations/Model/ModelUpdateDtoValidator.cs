using AbpAngularExample.DTOs.Models;
using FluentValidation;

namespace AbpAngularExample.Validations.Model
{
    public class ModelUpdateDtoValidator : AbstractValidator<ModelUpdateDto>
    {
        public ModelUpdateDtoValidator()
        {
            RuleFor(x => x.Id).NotEmpty();
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.BrandId).NotEmpty();
        }
    }
}
