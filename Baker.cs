using System;

namespace SolidBakery
{
    public class Baker
    {
        public void TakeOrder()
        {
            Console.WriteLine("Hello! Make an order:");

            var orderLine = Console.ReadLine();
            var order = Enum.Parse<Order>(orderLine);

            ChargeFee(order);

            Bake(order);
        }

        private void ChargeFee(Order order)
        {
            var fee = order switch
            {
                Order.Bread => 5,
                Order.Cookie => 1,
                Order.Cake => 10,
            };

            Console.WriteLine($"Your fee will be {fee}.");
            Console.WriteLine("Press Enter to pay.");
            Console.ReadKey();
        }

        private void Bake(Order order)
        {
            var product = order switch
            {
                Order.Bread => "Tasty bread",
                Order.Cookie => "Crispy cookies",
                Order.Cake => "Sweet cake",
            };

            Console.WriteLine($"Here is your order: {product}.");
            Console.WriteLine("Thank you!");
            Console.ReadKey();
        }
    }
}