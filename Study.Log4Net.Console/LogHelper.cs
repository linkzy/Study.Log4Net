using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace Study.Log4Net
{
    public class LogHelper
    {
        //Create a logger and use the file path as the name of the logger to make easier to identify where the log entry is comming from
        public static log4net.ILog GetLogger([CallerFilePathAttribute] string filename = "")
        {
            return log4net.LogManager.GetLogger(filename);
        }
    }
}
