using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class InterestRateValidator:AbstractValidator<InterestRate>
    {
        public InterestRateValidator()
        {
            RuleFor(x => x.InterestPercent).NotEmpty().WithMessage("Faiz oranı boş bırakılamaz");
        }
    }
}
