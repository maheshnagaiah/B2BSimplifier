using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft_Graph_Mail_Console_App
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            MailClient.SendMeAsync().Wait();
            Console.Read();
        }
    }
}
