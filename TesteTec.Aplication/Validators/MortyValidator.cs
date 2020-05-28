using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using TesteTec.Domain.Entities;

namespace TesteTec.Aplication.Validators
{
    public class MortyValidator : AbstractValidator<Morty>
    {
        public MortyValidator()
        {
            RuleFor(p => p).NotNull().OnAnyFailure(x =>
            {
                throw new ArgumentNullException("Objeto Invalido");
            });
          

        }
    }
}
