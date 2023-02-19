namespace Task_2
{
    delegate int Delegate();

    class Program
    {
        static void Main(string[] args)
        {
            Delegate[] delegates = new Delegate[15];

            for (int i = 0; i < 15; i++)
            {
                delegates[i] = delegate
                {
                    Random rnd = new Random();
                    return rnd.Next(1, 50);
                };
            }

            Func<Delegate[], double> average = delegate (Delegate[] sin)
            {
                double sum = 0;
                foreach (Delegate del in sin)
                {
                    sum += del();
                }
                return sum / sin.Length;
            };

            Console.WriteLine("The average value is: " + average(delegates));

            Console.ReadLine();
        }
    }
}