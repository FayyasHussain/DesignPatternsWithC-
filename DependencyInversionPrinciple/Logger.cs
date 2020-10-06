using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    public class FileLogger : ILogger
    {
        public void CreateLogEntry(string errorMessage)
        {
            File.WriteAllText(@"C:exceptions.txt", errorMessage);
        }
    }

    public class EmailLogger : ILogger
    {
        public void CreateLogEntry(string errorMessage)
        {
            throw new NotImplementedException();
        }
    }
    public class SmsLogger : ILogger
    {
        public void CreateLogEntry(string errorMessage)
        {
            throw new NotImplementedException();
        }
    }
}
