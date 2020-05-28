using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using TesteTec.Domain.Entities;

namespace TesteTec.Aplication.Validators
{
   public class DimensaoValidator : AbstractValidator<Dimensao>
    {
        public DimensaoValidator()
        {
            RuleFor(p => p).NotNull().OnAnyFailure(x =>
            {
                throw new ArgumentNullException("Objeto Invalido");
            });
            RuleFor(p => p.NomeDimensao).NotNull().WithMessage("Nome Dimensao não preenchido");
        }

    }
}
