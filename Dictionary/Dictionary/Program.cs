using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Program
    {
        public static async void Main(string[] args)
        {
            Task<bool> t = SendEmailAsync();
            Console.WriteLine("trying to send email");
            bool result = await t;
           
        }
        public static async Task<bool> SendEmailAsync()
        {
            Thread.Sleep(2000);
            Console.WriteLine("email sent");
            return true;
        }
    }
}

