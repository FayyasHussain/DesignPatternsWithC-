using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    public interface IDiscountCalculator
    {
        double CalculateRegularDiscount(double totalPrice);
        double CalculateBonusPointsDiscount(double totalPrice, int points);
    }
}
