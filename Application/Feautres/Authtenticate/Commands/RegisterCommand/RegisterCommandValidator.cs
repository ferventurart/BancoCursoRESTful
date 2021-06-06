using FluentValidation;

namespace Application.Feautres.Authtenticate.Commands.RegisterCommand
{
    public class RegisterCommandValidator : AbstractValidator<RegisterCommand>
    {
        public RegisterCommandValidator()
        {
            RuleFor(p => p.Nombre)
               .NotEmpty().WithMessage("{PropertyName} no puede ser vacio.")
               .MaximumLength(80).WithMessage("{PropertyName} no debe exceder de {MaxLength} caracteres");

            RuleFor(p => p.Apellido)
               .NotEmpty().WithMessage("{PropertyName} no puede ser vacio.")
               .MaximumLength(80).WithMessage("{PropertyName} no debe exceder de {MaxLength} caracteres");


            RuleFor(p => p.Email)
               .NotEmpty().WithMessage("{PropertyName} no puede ser vacio.")
               .EmailAddress().WithMessage("{PropertyName} debe ser una direccion de email valida")
               .MaximumLength(100).WithMessage("{PropertyName} no debe exceder de {MaxLength} caracteres");

            RuleFor(p => p.UserName)
               .NotEmpty().WithMessage("{PropertyName} no puede ser vacio.")
               .MaximumLength(10).WithMessage("{PropertyName} no debe exceder de {MaxLength} caracteres");

            RuleFor(p => p.Password)
               .NotEmpty().WithMessage("{PropertyName} no puede ser vacio.")
               .MaximumLength(15).WithMessage("{PropertyName} no debe exceder de {MaxLength} caracteres");


            RuleFor(p => p.ConfirmPassword)
               .NotEmpty().WithMessage("{PropertyName} no puede ser vacio.")
               .MaximumLength(15).WithMessage("{PropertyName} no debe exceder de {MaxLength} caracteres")
               .Equal(p => p.Password).WithMessage("{PropertyName} debe ser igual a Password");

        }
    }
}
