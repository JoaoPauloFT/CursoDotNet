using CursoDotNet.Models;
using FluentValidation;

namespace CursoDotNet.Validator
{
	public class UserValidator : AbstractValidator<UserViewModel>
	{
		public UserValidator() 
		{
			RuleFor(user => user.Email).EmailAddress().WithMessage("E-mail Invalido");
			//RuleFor(user => user.UserName).NotNull();
			RuleFor(user => user.Password).NotNull().WithMessage("Senha Vazia");
		}
	}
}
