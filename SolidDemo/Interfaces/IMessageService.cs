using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDemo.Interfaces
{
    /// <summary>
    /// Interface Segregation Principle
    /// </summary>
    public interface IMessageService
    {
        void Send(string customer, string message);
    }
}
