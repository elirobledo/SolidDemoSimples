using SolidDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDemo.Discounts
{
    public class RegularDiscount : IDiscount
    {
        public decimal Apply(decimal total)
        {
            return total * 0.95m;
        }
    }
}
