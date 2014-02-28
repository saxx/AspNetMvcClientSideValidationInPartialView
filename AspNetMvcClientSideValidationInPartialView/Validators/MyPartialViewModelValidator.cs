using AspNetMvcClientSideValidationInPartialView.Models;
using FluentValidation;

namespace AspNetMvcClientSideValidationInPartialView.Validators
{
    public class MyPartialViewModelValidator<T> : AbstractValidator<T> where T : MyPartialViewModel
    {
        public MyPartialViewModelValidator()
        {
            RuleFor(x => x.PropertyInMyPartialViewModel).NotEmpty().WithMessage("Message from MyPartialViewModelValidator.");
            RuleFor(x => x.AnotherPropertyInMyPartialViewModel).NotEmpty().WithMessage("Another message from MyPartialViewModelValidator.");
        }
    }
}