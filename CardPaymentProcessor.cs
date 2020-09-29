using System;

namespace SolidBakery
{
    public class CardPaymentProcessor : PaymentProcessor, IStatisticsCalculator
    {
        public override void ChargeFee(Order order, CardType? cardType = null)
        {
            if (cardType is null)
            {
                throw new ArgumentNullException(nameof(cardType));
            }

            var fee = GetOrderFee(order);

            Console.WriteLine($"Your fee will be {fee}.");
            Console.WriteLine("Press Enter to pay.");
            Console.ReadKey();

            Console.WriteLine("Connecting...");
            Console.WriteLine("Charging money...");
            Console.WriteLine("Success");
            Console.ReadKey();
        }

        public decimal CalculateStatistics()
        {
            var rnd = new Random();
            return rnd.Next();
        }
    }
}