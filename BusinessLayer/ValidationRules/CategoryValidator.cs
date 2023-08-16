using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            // Kategori Adı boş geçilemez ve en az 3 karakter olmalıdır.
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori Adını Boş Geçemezsiniz");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("Lütfen En Az 3 Karakter Girişi Yapın");

            // Açıklama boş geçilemez.
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Açıklamayı Boş Geçemezsiniz");

            // Kategori Adı en fazla 20 karakter olmalıdır.
            RuleFor(X => X.CategoryName).MaximumLength(20).WithMessage("Lütfen 20 Karakterden Fazla Değer Girişi Yapmayın");
        }
    }
}
