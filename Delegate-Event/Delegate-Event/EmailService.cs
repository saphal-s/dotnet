using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Event
{
    public class EmailService
    {
        public void SendEmail(object source ,EventArgs e)
        {
            Console.WriteLine("Email Sent");
        }
    }
}
