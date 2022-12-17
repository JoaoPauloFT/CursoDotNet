using CursoDotNet.Models;
using CursoDotNet.Validator;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace CursoDotNet.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            UserViewModel user = new UserViewModel();

			user.Email= "ghsadkjg";

			UserValidator validator = new UserValidator();

			ValidationResult results = validator.Validate(user);

			if (!results.IsValid)
			{
				foreach (var error in results.Errors)
				{
					Console.WriteLine("Property " + error.PropertyName + " failed validation. Error was: " + error.ErrorMessage);
				}
			}

			return View("Index", user);
        }

		[HttpPost]
        public IActionResult Test(UserViewModel user)
        {

			user.Email = "Email enviado";
			return View("Index", user);
		}
    }
}
