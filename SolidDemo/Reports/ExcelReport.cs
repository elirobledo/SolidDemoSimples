using SolidDemo.Interfaces;
using SolidDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDemo.Reports
{

    public class ExcelReport : IReport
    {
        public void Generate(Order order)
        {
            Console.WriteLine($"Reporte Excel generado para pedido {order.Id}");
        }
    }
}
