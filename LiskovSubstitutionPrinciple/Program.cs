using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            // You should be able to use any derived class instead of a parent class and have it behaved in the same manner wihout modification.
            var _discountCalculators = new List<DiscountCalculator>();
            _discountCalculators.Add(new SilverDiscountCalculator());
            _discountCalculators.Add(new GoldDiscountCalculator());
            _discountCalculators.Add(new PlatinumDiscountCalculator());
            foreach (DiscountCalculator discountCalculator in _discountCalculators)
            {
                double bonusPointsDiscount = discountCalculator.CalculateBonusPointsDiscount(1250, 50);
            }
        }
    }
}
