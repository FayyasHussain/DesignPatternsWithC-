using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    public abstract class DiscountCalculator
    {
        public virtual double CalculateRegularDiscount(double totalPrice)
        {
            return totalPrice;
        }

        public virtual double CalculateBonusPointsDiscount(double totalPrice, int points)
        {
            return totalPrice;
        }
    }

    public class SilverDiscountCalculator : DiscountCalculator
    {
        public override double CalculateRegularDiscount(double totalPrice)
        {
            return base.CalculateRegularDiscount(totalPrice) - 20;
        }
        public override double CalculateBonusPointsDiscount(double totalPrice, int points)
        {
            return totalPrice - points * 0.5;
        }
    }

    public class GoldDiscountCalculator : DiscountCalculator
    {
        public override double CalculateRegularDiscount(double totalPrice)
        {
            return base.CalculateRegularDiscount(totalPrice) - 50;
        }
        public override double CalculateBonusPointsDiscount(double totalPrice, int points)
        {
            return totalPrice - points * 1;
        }
    }

    public class PlatinumDiscountCalculator : DiscountCalculator
    {
        public override double CalculateRegularDiscount(double totalPrice)
        {
            return base.CalculateRegularDiscount(totalPrice) - 100;
        }
        public override double CalculateBonusPointsDiscount(double totalPrice, int points)
        {
            throw new InvalidOperationException("Not applicable for Platinum orders.");
        }
    }

    public interface IRegularDiscountCalculator
    {
        double CalculateRegularDiscount(double totalPrice);
    }
    public interface IBonusPointsDiscountCalculator
    {
        double CalculateBonusPointsDiscount(double totalPrice, int points);
    }
}
