using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    public enum OrderType
    {
        Silver,
        Gold,
        Platinum
    }
    public class CustomerOrder_Failing
    {
        public void CreateOrder(OrderType orderType)
        {
            try
            {
                // Create order for application.
            }
            catch
            {
                // This breaks Single Responsibility principle.
                switch (orderType)
                {
                    case OrderType.Gold:
                        new SmsLogger().CreateLogEntry("Gold order failed");
                        break;
                    case OrderType.Silver:
                        new EmailLogger().CreateLogEntry("Silver order failed");
                        break;
                    case OrderType.Platinum:
                        new FileLogger().CreateLogEntry("platinum order failed");
                        break;
                }
            }
        }


    }
}
