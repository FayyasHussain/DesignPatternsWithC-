using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class FileLogger
    {
        public void CreateLogEntry(string logMessage)
        {
            System.IO.File.WriteAllText(System.AppDomain.CurrentDomain.BaseDirectory + "\\WriteLines.txt", "Order Created");
        }
    }
}
