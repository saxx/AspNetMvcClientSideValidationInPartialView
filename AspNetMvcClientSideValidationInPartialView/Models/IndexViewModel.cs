using AspNetMvcClientSideValidationInPartialView.Validators;
using FluentValidation.Attributes;

namespace AspNetMvcClientSideValidationInPartialView.Models
{
    [Validator(typeof(IndexViewModelValidator))]
    public class IndexViewModel : MyPartialViewModel
    {
        public string PropertyInIndexViewModel { get; set; }
    }
}