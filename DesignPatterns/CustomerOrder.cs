using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class CustomerOrder
    {
        FileLogger _fileLogger = new FileLogger();

        // Single Responsibility Principle
        public void CreateOrder()
        {
            try
            {
                // Create an Order
            }
            catch
            {
                _fileLogger.CreateLogEntry("first message");
            }
        }
    }
}
