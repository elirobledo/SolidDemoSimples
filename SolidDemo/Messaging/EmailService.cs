using SolidDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDemo.Messaging
{

    public class EmailService : IMessageService
    {
        public void Send(string customer, string message)
        {
            Console.WriteLine($"Email enviado a {customer}: {message}");
        }
    }
}
