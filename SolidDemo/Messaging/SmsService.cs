using SolidDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDemo.Messaging
{
    public class SmsService : IMessageService
    {
        public void Send(string customer, string message)
        {
            Console.WriteLine($"SMS enviado a {customer}: {message}");
        }
    }
}
