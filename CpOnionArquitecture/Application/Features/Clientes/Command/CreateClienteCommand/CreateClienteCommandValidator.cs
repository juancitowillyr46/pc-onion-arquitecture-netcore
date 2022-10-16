using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Clientes.Command.CreateClienteCommand
{
    public class CreateClienteCommandValidator: AbstractValidator<CreateClienteCommand>
    {
        public CreateClienteCommandValidator()
        {
            RuleFor(p => p.Nombre).NotEmpty().WithMessage("{PropertyName} no puede ser vacío.")
                                  .MaximumLength(120).WithMessage("{PropertyName} no puede exceder {MaxLength}.");
            RuleFor(p => p.Apellido).NotEmpty().WithMessage("{PropertyName} no puede ser vacío")
                                  .MaximumLength(120).WithMessage("{PropertyName} no puede exceder {MaxLength}.");
            RuleFor(p => p.FechaNacimiento).NotEmpty().WithMessage("{PropertyName} no puede ser vacío.");

            RuleFor(p => p.Telefono).NotEmpty().WithMessage("{PropertyName} no puede ser vacío.")
                                    .Matches(@"\d{4}-\d{4}$").WithMessage("{PropertyName} debe cumplir con el formato 0000-0000.")
                                    .MaximumLength(9).WithMessage("{PropertyName} no puede exceder {MaxLength}.");
            RuleFor(p => p.Email).NotEmpty().WithMessage("{PropertyName} no puede ser vacío.")
                                                .EmailAddress().WithMessage("{PropertyName} debe ser una dirección de email valida")
                                                .MaximumLength(120).WithMessage("{PropertyName} no puede exceder {MaxLength}.");
            RuleFor(p => p.Direccion).NotEmpty().WithMessage("{PropertyName} no puede ser vacío")
                                  .MaximumLength(120).WithMessage("{PropertyName} no puede exceder {MaxLength}.");
        }
    }
}
