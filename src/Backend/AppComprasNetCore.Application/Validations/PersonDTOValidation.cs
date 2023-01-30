using AppComprasNetCore.Application.DTOs;
using FluentValidation;

namespace AppComprasNetCore.Application.Validations;

public class PersonDTOValidation : AbstractValidator<PersonDTO>
{
	public PersonDTOValidation()
	{
		RuleFor(c => c.Name)
			.NotEmpty()
			.NotNull()
			.WithMessage("Nome deve ser informado!");

		RuleFor(c => c.Document)
			.NotEmpty()
			.NotNull()
			.WithMessage("Documento deve ser informado!");

		RuleFor(c => c.Phone)
			.NotEmpty()
			.NotNull()
			.WithMessage("Telefone deve ser informado!");
	}
}
