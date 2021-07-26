using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
   public class WriterValidator:AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            //kural tanımlamaları
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adını boş geçemezsiniz");
            RuleFor(x => x.WriterSurname).NotEmpty().WithMessage("Yazar soyadını boş geçemezsiniz");
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Hakkında kısmını boş geçemezsiniz");
            RuleFor(x => x.WriterSurname).MinimumLength(2).WithMessage("2 karakterden az olamaz");
            RuleFor(x => x.WriterSurname).MaximumLength(50).WithMessage("Lütfen 20 karakterden fazla giremezsiniz");
            RuleFor(x => x.WriterTitle).MaximumLength(50).WithMessage("Ünvan Kısmını boş geçemezsiniz");
        }
    }
}
