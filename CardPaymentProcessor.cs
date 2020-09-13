using System;

namespace SolidBakery
{
    public class CardPaymentProcessor : PaymentProcessor
    {
        public override void ChargeFee(Order order)
        {
            var fee = GetOrderFee(order);

            Console.WriteLine($"Your fee will be {fee}.");
            Console.WriteLine("Press Enter to pay.");
            Console.ReadKey();

            Console.WriteLine("Connecting...");
            Console.WriteLine("Charging money...");
            Console.WriteLine("Success");
            Console.ReadKey();
        }
    }
}