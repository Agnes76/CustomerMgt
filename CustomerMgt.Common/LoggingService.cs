using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerMgt.Common
{
    public static class LoggingService 
    {
        public static void WriteTofile(List<ILoggable> itemsToLog)
        {
            foreach (var item in itemsToLog) 
            { 
                Console.WriteLine(item.Log());
            }
        }
    }
}
