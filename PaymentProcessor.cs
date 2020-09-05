using System;

namespace SolidBakery
{
    public class PaymentProcessor
    {
        public void ChargeFee(Order order)
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
    }
}