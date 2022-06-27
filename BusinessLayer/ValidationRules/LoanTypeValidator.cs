using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class LoanTypeValidator: AbstractValidator<LoanType>
    {
        public LoanTypeValidator()
        {
            RuleFor(x => x.TypeName).NotEmpty().WithMessage("Kredi türü boş bırakılamaz.");
        }
    }
}
