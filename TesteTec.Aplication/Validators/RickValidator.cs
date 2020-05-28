using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using TesteTec.Domain.Entities;

namespace TesteTec.Aplication.Validators
{
    public class RickValidator : AbstractValidator<Rick>
    {
        public RickValidator()
        {
            RuleFor(c => c).NotNull().OnAnyFailure(x =>
            {
                throw new ArgumentNullException("Objeto Invalido");
            });
            RuleFor(c => c.Dimensao).NotNull().WithMessage("Dimensao não preenchida");
        }
    }
}
