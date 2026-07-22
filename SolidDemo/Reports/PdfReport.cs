using SolidDemo.Interfaces;
using SolidDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDemo.Reports
{
    public class PdfReport : IReport
    {
        public void Generate(Order order)
        {
            Console.WriteLine($"Reporte PDF generado para pedido {order.Id}");
        }
    }
}
