using SolidDemo.Interfaces;
using SolidDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDemo.Services
{
    public class OrderService
    {
        private readonly IRepository repository;
        private readonly IMessageService messageService;
        private readonly IDiscount discount;
        private readonly IReport report;

        public OrderService(
            IRepository repository,
            IMessageService messageService,
            IDiscount discount,
            IReport report)
        {
            this.repository = repository;
            this.messageService = messageService;
            this.discount = discount;
            this.report = report;
        }

        public void Process(Order order)
        {
            order.Total = discount.Apply(order.Total);

            repository.Save(order);

            report.Generate(order);

            messageService.Send(order.Customer,
                $"Su pedido fue procesado. Total: {order.Total:C}");
        }
    }
}
