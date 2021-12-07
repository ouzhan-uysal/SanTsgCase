using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class HotelValidator : AbstractValidator<Hotel>
    {
        public HotelValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Servis ismi boş bırakılamaz.");
            RuleFor(x => x.Location).NotEmpty().WithMessage("Lokasyon seçiniz.");
            RuleFor(x => x.Capacity).NotEmpty().WithMessage("Kapasite boş bırakılamaz.");
            RuleFor(x => x.PricePerAdult).NotEmpty().WithMessage("Yetişkin ücreti boş bırakılamaz.");
            RuleFor(x => x.PricePerChild).NotEmpty().WithMessage("Çocuk ücreti boş bırakılamaz.");
        }
    }
}
