using BYBlog.Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYBlog.BL.ValidationRules
{
    public class UserValidator:AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("First Name cannot be empty");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("Last Name cannot be empty");
            RuleFor(x => x.EmailAddress).NotEmpty().WithMessage("Email address cannot be empty");
            RuleFor(x => x.FirstName).MinimumLength(2).WithMessage("First Name must be at least 2 character");
            RuleFor(x => x.FirstName).MaximumLength(50).WithMessage("First Name cannot exceed 50 characters");
            RuleFor(x => x.LastName).MinimumLength(2).WithMessage("Last Name must be at least 2 character");
            RuleFor(x => x.LastName).MaximumLength(50).WithMessage("Last Name cannot exceed 50 characters");
            RuleFor(x => x.Password).Equal(x => x.ConfirmPassword).WithMessage("Passwords do not match");
        }
    }
}
