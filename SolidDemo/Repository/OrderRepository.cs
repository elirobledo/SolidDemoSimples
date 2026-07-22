using SolidDemo.Interfaces;
using SolidDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDemo.Repository
{
    public class OrderRepository : IRepository
    {
        public void Save(Order order)
        {
            Console.WriteLine($"Pedido {order.Id} guardado.");
        }
    }
}
