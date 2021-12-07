using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(x => x.Username).NotEmpty().WithMessage("Username Boş Bırakılamaz.");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Password Boş Bırakılamaz.");
            RuleFor(x => x.Repassword).Equal(x => x.Password).WithMessage("Password'lar eşleşmiyor.");
        }
    }
}
