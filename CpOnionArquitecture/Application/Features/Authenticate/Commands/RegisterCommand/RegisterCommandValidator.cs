using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Authenticate.Commands.RegisterCommand
{
    public class RegisterCommandValidator : AbstractValidator<RegisterCommand>
    {
        public RegisterCommandValidator()
        {
            RuleFor(p => p.Nombre).NotEmpty().WithMessage("{PropertyName} no puede ser vacío.")
                                 .MaximumLength(120).WithMessage("{PropertyName} no puede exceder {MaxLength}.");
            RuleFor(p => p.Apellido).NotEmpty().WithMessage("{PropertyName} no puede ser vacío")
                                  .MaximumLength(120).WithMessage("{PropertyName} no puede exceder {MaxLength}.");
           
            RuleFor(p => p.Email).NotEmpty().WithMessage("{PropertyName} no puede ser vacío.")
                                                .EmailAddress().WithMessage("{PropertyName} debe ser una dirección de email valida")
                                                .MaximumLength(120).WithMessage("{PropertyName} no puede exceder {MaxLength}.");

            RuleFor(p => p.UserName).NotEmpty().WithMessage("{PropertyName} no puede ser vacío.")
                                                .MaximumLength(120).WithMessage("{PropertyName} no puede exceder {MaxLength}.");

            RuleFor(p => p.Password).NotEmpty().WithMessage("{PropertyName} no puede ser vacío.")
                                                .MaximumLength(120).WithMessage("{PropertyName} no puede exceder {MaxLength}.");

            RuleFor(p => p.ConfirmPassword).NotEmpty().WithMessage("{PropertyName} no puede ser vacío.")
                                                .EmailAddress().WithMessage("{PropertyName} debe ser una dirección de email valida")
                                                .MaximumLength(120).WithMessage("{PropertyName} no puede exceder {MaxLength}.")
                                                .Equal(p => p.Password).WithMessage("{PropertyName} Debe ser igual al Password");
        }
    }
}
