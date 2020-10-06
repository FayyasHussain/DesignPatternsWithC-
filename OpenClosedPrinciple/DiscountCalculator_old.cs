using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    public enum OrderType
    {
        Normal,
        Silver
    }
    public class DiscountCalculator_old
    {
        public double CalculateDiscount(OrderType orderType, double totalPrice)
        {
            if(orderType == OrderType.Normal)
            {
                return totalPrice * 0.2;
            }
            else
            {
                return totalPrice * 0.3;
            }
        }
    }
}
