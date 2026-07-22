using SolidDemo.Interfaces;
using SolidDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDemo.Services
{
    /// <summary>
    /// Dependency Inversion Principle
    /// 
    /// OrderService It depends on abstractions, not concrete implementations.
    /// </summary>
    public class OrderService
    {
        private readonly IRepository repository;
        private readonly IMessageService messageService;
        private readonly IDiscount discount;
        private readonly IReport report;

        public OrderService(
            IRepository repository,
            IMessageService messageService,///not EmailService email = new EmailService();
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
            ///
            /// Liskov Substitution Principle
            ///
            /// All discounts can be replaced without breaking the system
            /// Example: No discount, Premium discount, Regular discount

            order.Total = discount.Apply(order.Total);

            repository.Save(order);

            report.Generate(order);

            messageService.Send(order.Customer,
                $"Su pedido fue procesado. Total: {order.Total:C}");
        }
    }
}
