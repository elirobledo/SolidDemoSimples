using SolidDemo.Discounts;
using SolidDemo.Messaging;
using SolidDemo.Models;
using SolidDemo.Reports;
using SolidDemo.Repository;
using SolidDemo.Services;

var order = new Order
{
    Id = 1001,
    Customer = "Rita",
    Total = 1000
};

var service = new OrderService(
    new OrderRepository(),
    new EmailService(),
    new PremiumDiscount(),
    new PdfReport());

service.Process(order);