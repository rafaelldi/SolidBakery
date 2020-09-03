namespace SolidBakery
{
    class Program
    {
        static void Main()
        {
            var baker = new Baker();

            while (true)
            {
                baker.TakeOrder();
            }
        }
    }
}
