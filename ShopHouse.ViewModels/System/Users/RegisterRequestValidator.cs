using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopHouse.ViewModels.System.Users
{
    public class RegisterRequestValidator : AbstractValidator<RegisterRequest>
    {
        public RegisterRequestValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("FirstName is required")
                .MaximumLength(200).WithMessage("FirstName cannot over 200 characters");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("LastName is required")
                .MaximumLength(200).WithMessage("LastName cannot over 200 characters");

            RuleFor(x => x.Dob).GreaterThan(DateTime.Now.AddYears(-100)).WithMessage("Birthday cannot greater than 100 year");

            RuleFor(x => x.Email).NotEmpty().WithMessage("Email is required")
                .Matches(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")
                .WithMessage("Email format not match");

            RuleFor(x => x.PhoneNumber).NotEmpty().WithMessage("PhoneNumber is required");

            RuleFor(x => x.UserName).NotEmpty().WithMessage("UserName is required");

            RuleFor(x => x.Password).NotEmpty().WithMessage("Password is required")
                .MinimumLength(6)
                .WithMessage("Password is at least 6 character");
            RuleFor(x => x).Custom((request, context) =>
            {
                if (request.Password != request.ConfirmPassword)
                {
                    context.AddFailure("ConfirmPassword is not match");
                }
            });
        }
    }
}
