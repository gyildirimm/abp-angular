using AbpAngularExample.DTOs.Cars;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbpAngularExample.Validations.Car
{
    public class CarCreateDtoValidator : AbstractValidator<CarCreateDto>
    {
        public CarCreateDtoValidator()
        {
            RuleFor(x => x.ModelId).NotEmpty();
            RuleFor(x => x.Year).NotEmpty().GreaterThanOrEqualTo(1886);
            RuleFor(x => x.PurchaseDate).NotEmpty();
            RuleFor(x => x.InvoiceAmount).NotEmpty().GreaterThan(0);
        }
    }
}
