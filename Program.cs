namespace SolidBakery
{
    class Program
    {
        static void Main(string[] args)
        {
            var processor = PaymentProcessor.Create(args.Length > 0);
            var baker = new Baker(processor);

            while (true)
            {
                baker.TakeOrder();
            }
        }
    }
}
