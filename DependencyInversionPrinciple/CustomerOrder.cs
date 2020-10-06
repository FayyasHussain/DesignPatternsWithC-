using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    public class CustomerOrder
    {
        private ILogger _logger;

        public CustomerOrder(ILogger logger)
        {
            _logger = logger;
        }

        public void CreateOrder()
        {
            try
            {

            }
            catch(Exception ex)
            {
                _logger.CreateLogEntry(ex.Message);
            }
        }
    }

    public class GoldCustomerOrder : CustomerOrder
    {
        GoldCustomerOrder() : base( new EmailLogger())
        {

        }
    }

    public class SilverCustomerOrder: CustomerOrder
    {
        SilverCustomerOrder(): base(new SmsLogger())
        {

        }
    }
}
