using System;

namespace SolidBakery
{
    public class Baker
    {
        private readonly PaymentProcessor _paymentProcessor;

        public Baker()
        {
            _paymentProcessor = PaymentProcessor.Create(true);
        }

        public void TakeOrder()
        {
            Console.WriteLine("Hello! Make an order:");

            var orderLine = Console.ReadLine();
            var order = Enum.Parse<Order>(orderLine);

            _paymentProcessor.ChargeFee(order);

            Bake(order);
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