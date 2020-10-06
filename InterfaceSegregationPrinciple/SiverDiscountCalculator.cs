using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    public class SiverDiscountCalculator : IDiscountCalculator
    {
        public double CalculateBonusPointsDiscount(double totalPrice, int points)
        {
            return totalPrice - points * 0.3;
        }

        public double CalculateRegularDiscount(double totalPrice)
        {
            return totalPrice - 30;
        }
    }

    public class PlatinueDiscountCalculator : IDiscountCalculator
    {
        public double CalculateBonusPointsDiscount(double totalPrice, int points)
        {
            throw new NotImplementedException("not applicable for platinum orders");
        }

        public double CalculateRegularDiscount(double totalPrice)
        {
            return totalPrice - 50;
        }
    }
}
