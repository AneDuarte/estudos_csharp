using MiniEcommerce.Entities.Enums;
using MiniEcommerce.Entities;
using System.Globalization;
using System;

namespace MiniEcommerce
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("Enter the client data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Birth date (DD/MM/YYYY): ");
            DateOnly birthDate = DateOnly.Parse(Console.ReadLine());

            Client cli = new Client(name, email, birthDate);

            Console.WriteLine("Enter the order data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Order order = new Order(DateTime.Now, status, cli);

            Console.Write("How many items to this order: ");
            int numItems = int.Parse(Console.ReadLine());

            for (int i = 0; i < numItems; i++)
            {
                Console.WriteLine($"Enter #{i + 1} order data: ");
                Console.Write("Product name: ");
                string prodName = Console.ReadLine();

                Console.Write("Product price: ");
                double prodPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product prod = new Product(prodName, prodPrice);

                Console.Write("Quantity: ");
                int itemQt = int.Parse(Console.ReadLine());

                OrderItem oi = new OrderItem(itemQt, prod.Price, prod);

                order.AddItem(oi);

            }

            Console.WriteLine();
            Console.WriteLine("Order sumary: ");
            Console.WriteLine(order);

        }
    }
}