using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Clientes.Command.DeleteClienteCommand
{
    public class DeleteClienteCommandValidator : AbstractValidator<DeleteClienteCommand>
    {
        public DeleteClienteCommandValidator()
        {
            RuleFor(p => p.Id).NotEmpty().WithMessage("{PropertyName} no puede ser vacío");
        }
        
    }
}
