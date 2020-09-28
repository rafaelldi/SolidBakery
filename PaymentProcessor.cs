using System;

namespace SolidBakery
{
    public abstract class PaymentProcessor
    {
        public static PaymentProcessor Create(bool hasPaymentTerminal) =>
            hasPaymentTerminal switch
            {
                true => new CardPaymentProcessor(),
                false => new CashPaymentProcessor()
            };
        
        public abstract void ChargeFee(Order order, CardType? cardType = null);

        protected decimal GetOrderFee(Order order) =>
            order switch
            {
                Order.Bread => 5,
                Order.Cookie => 1,
                Order.Cake => 10,
            };
    }
}