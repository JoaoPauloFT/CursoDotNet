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
            return View("Index", user);
        }
        public IActionResult Test(UserViewModel user)
        {

            UserValidator validator = new UserValidator();

            ValidationResult results = validator.Validate(user);

            if(!results.IsValid) 
            {
                foreach (var error in results.Errors)
                {
                    Console.WriteLine("Property " + error.PropertyName + " failed validation. Error was: " + error.ErrorMessage);
                }
			}

			user.Email = "Email enviado";
			return View("Index", user);
		}
    }
}
