using SolidDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDemo.Interfaces
{
    public interface IRepository
    {
        void Save(Order order);
    }
}
