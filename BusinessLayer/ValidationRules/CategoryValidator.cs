using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidator:AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            //kural tanımlamaları
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori adını boş geçemezsiniz");
            RuleFor(x => x.CategortDescription).NotEmpty().WithMessage("Açıklamayı adını boş geçemezsiniz");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("3 karakterden az olamaz");
            RuleFor(x=>x.CategoryName).MaximumLength(20).WithMessage("Lütfen 20 karakterden fazla giremezsiniz");
        }
    }
}
