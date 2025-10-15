using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPISP
{
    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            System.IO.File.AppendAllText("log.txt", $"Log: {message}{Environment.NewLine}");
        }
    }
}
