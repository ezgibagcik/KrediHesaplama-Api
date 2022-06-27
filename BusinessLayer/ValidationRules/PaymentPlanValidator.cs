using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class PaymentPlanValidator : AbstractValidator<PaymentPlan>
    {
        public PaymentPlanValidator()
        {
            RuleFor(x => x.InstallmentAmount).NotEmpty().WithMessage("Kredi tutarı boş bırakılamaz.");
        }
    }
}
