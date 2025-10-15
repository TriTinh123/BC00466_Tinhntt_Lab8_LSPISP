using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPISP
{
    internal class EmailNotifier : INotifier
    {
        public void Notify(string message)
        {
            // Logic to send email notification
            Console.WriteLine($"Email notification sent: {message}");
        }
    }
}
