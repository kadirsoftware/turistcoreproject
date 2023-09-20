using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AboutValidator :AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(X => X.Description).NotEmpty().WithMessage("Açıklama kısmı boş bırakılamaz.");
            RuleFor(X => X.Image1).NotEmpty().WithMessage("Lütfen görsel seçiniz.");
            RuleFor(X => X.Description).MinimumLength(50).WithMessage("Lütfen min. 50 karakterlik açıklama bilgisi giriniz.");
            RuleFor(X => X.Description).MaximumLength(1500).WithMessage("Lütfen max. 1500 karakterlik açıklama bilgisi giriniz.");
        }
    }
}
