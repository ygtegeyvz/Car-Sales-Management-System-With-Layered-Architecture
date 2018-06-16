using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
   public class AdValidation:AbstractValidator<Ad>
    {
        public AdValidation()
        {
            RuleFor(p => p.Ilan_Adi).NotEmpty();
            RuleFor(p => p.Ilan_Fiyat).NotEmpty();
            RuleFor(p => p.Ilan_Km).NotEmpty();
            RuleFor(p => p.Ilan_Tarih).NotEmpty();
            RuleFor(p => p.Ilan_Fiyat).GreaterThan(0);
            RuleFor(p => p.Ilan_Adi).MinimumLength(6);
            RuleFor(p => p.Ilan_Fiyat).GreaterThan(100000).When(p => p.Ilan_ArabaID == 7);

            //RuleFor(p => p.Ilan_Adi).Must(StartsWithA);

        }

        //private bool StartsWithA(string arg)
        //{
        //    return arg.StartsWith("A");
        //}
    }
}
