# SolidDemo

Proyecto desarrollado en C# (.NET 8) para demostrar la aplicación de los cinco principios SOLID.

## Tecnologías

- C#
- .NET 8
- Visual Studio 2022

## Principios implementados

- Single Responsibility Principle (SRP)
- Open/Closed Principle (OCP)
- Liskov Substitution Principle (LSP)
- Interface Segregation Principle (ISP)
- Dependency Inversion Principle (DIP)

## Estructura

- Models
- Interfaces
- Discounts
- Messaging
- Repository
- Reports
- Services

## Example
S — Single Responsibility Principle
Cada clase tiene una sola responsabilidad.
Clase	            Responsabilidad
OrderRepository	  Guardar pedidos
EmailService	    Enviar emails

------------------------------------------

O — Open/Closed Principle
Para agregar un nuevo descuento no se modifica el código existente.
Solo se crea otra clase: public class BlackFridayDiscount : IDiscount....

## Ejecución

```bash
dotnet run
```
