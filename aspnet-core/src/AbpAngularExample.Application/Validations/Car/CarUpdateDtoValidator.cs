using AbpAngularExample.DTOs.Cars;
using FluentValidation;

namespace AbpAngularExample.Validations.Car
{
    public class CarUpdateDtoValidator : AbstractValidator<CarUpdateDto>
    {
        public CarUpdateDtoValidator()
        {
            RuleFor(x => x.Id).NotEmpty();
            RuleFor(x => x.ModelId).NotEmpty();
            RuleFor(x => x.Year).NotEmpty().GreaterThanOrEqualTo(1886);
            RuleFor(x => x.PurchaseDate).NotEmpty();
            RuleFor(x => x.InvoiceAmount).NotEmpty().GreaterThan(0);
        }
    }
}
