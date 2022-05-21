using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Event
{
    public class OrderProcessor
    {
        public delegate void OrederProcessHandler(object source, EventArgs e);//delegate for events- delegate define
        public event OrederProcessHandler OrderProcess;
        public void ProcessOrder(Order o)
        {
            Console.WriteLine($"Order processed order Id:{o.Id}");
            // EmailService emailService = new EmailService();
            // emailService.SendEmail();
           OnOrderProcess();
        }

        protected virtual void OnOrderProcess()
        {
            if(OrderProcess != null)
            {
                OrderProcess(this, EventArgs.Empty);//event raised
            }
        }
    }
}
