using AbpAngularExample.DTOs.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbpAngularExample.Validations.Model
{
    public class ModelCreateDtoValidator : AbstractValidator<ModelCreateDto>
    {
        public ModelCreateDtoValidator()
        {
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.BrandId).NotEmpty();
        }
    }
}
