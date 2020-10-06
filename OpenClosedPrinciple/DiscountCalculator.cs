using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    /// <summary>
    /// Discount Calculator class is open for extension but closed for Modification.
    /// </summary>
    public class DiscountCalculator
    {
        public virtual double DiscountCalculate(double totalPrice)
        {
            return 0;
        }
    }

    public class SilverDiscountCalculator : DiscountCalculator
    {
        public override double DiscountCalculate(double totalPrice)
        {
            return totalPrice * 0.4;
        }
    }

    public class GoldDiscountCalculator : DiscountCalculator
    {
        public override double DiscountCalculate(double totalPrice)
        {
            return totalPrice * 0.4;
        }
    }

}
