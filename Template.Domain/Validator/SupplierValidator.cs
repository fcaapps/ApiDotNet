using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using Template.Domain.Entities;

namespace Template.Domain.Validator
{
    public class SupplierValidator : AbstractValidator<Supplier>
    {
        public SupplierValidator()
        {
            RuleFor(x => x.RazaoSocial).NotNull().NotEmpty().MinimumLength(10).MaximumLength(150);
            RuleFor(x => x.NomeFantasia).NotNull().NotEmpty().MinimumLength(10).MaximumLength(100);
            RuleFor(x => x.DateCreated).NotNull().NotEmpty().LessThan(DateTime.Now).GreaterThan(DateTime.Now);
            RuleFor(x => x.Cnpj).NotNull().NotEmpty().Matches("[0..9]").WithMessage("CNPJ Não pode conter letras");            

        }
    }
}
