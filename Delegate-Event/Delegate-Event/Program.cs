using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Event.Event
{
    public class Program
    {
        public static void Main(string[] args)
        {

            //Order O = new Order{Id = 1};

            //OrderProcessor orderProcessor = new OrderProcessor();

            // EmailService emailService = new EmailService();

            // orderProcessor.OrderProcess += emailService.SendEmail;

            // orderProcessor.ProcessOrder(O);

            CustomLIst<int> lst = new CustomLIst<int>();

            lst.ItemAdded += (sender, e) =>
            {
                Console.WriteLine("New item added to the list");
            };
            lst.Add(1);
            lst.Add(2);
            lst.Add(3);

            foreach (int i in lst)
            {
                Console.WriteLine(i);
            }
        }
    }
}
