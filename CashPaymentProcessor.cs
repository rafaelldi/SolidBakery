using System;

namespace SolidBakery
{
    public class CashPaymentProcessor : PaymentProcessor
    {
        public override void ChargeFee(Order order)
        {
            var fee = GetOrderFee(order);

            Console.WriteLine($"Your fee will be {fee}.");
            Console.WriteLine("Press Enter to pay.");
            Console.ReadKey();
        }
    }
}