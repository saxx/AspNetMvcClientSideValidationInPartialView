using AspNetMvcClientSideValidationInPartialView.Models;
using FluentValidation;

namespace AspNetMvcClientSideValidationInPartialView.Validators
{
    public class IndexViewModelValidator : MyPartialViewModelValidator<IndexViewModel>
    {
        public IndexViewModelValidator()
        {
            RuleFor(x => x.PropertyInIndexViewModel).NotEmpty().WithMessage("Message from IndexViewModelValidator.");
        }
    }
}