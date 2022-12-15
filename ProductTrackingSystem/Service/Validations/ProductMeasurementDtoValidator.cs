using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using MyJeweleryShop.Core.DTOs;
using MyJeweleryShop.Core.Services;

namespace MyJeweleryShop.Service.Validations
{
    public class ProductMeasurementDtoValidator : AbstractValidator<ProductDto>
    {
        public ProductMeasurementDtoValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("{PropertyName} is required").NotEmpty().WithMessage("{PropertyName} is required");
            RuleFor(x => x.ShortCode).NotEmpty().WithMessage("{PropertyShortCode} is required").NotEmpty().WithMessage("{PropertyShortCode} is required");

        }
    }
}
