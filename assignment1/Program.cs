using System;

namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }

        void Start()
        {
            // template method. 
            PrintHeader("[CreditCard]");
            BetaalWijze ccBetaling = new CreditCardBetaling();
            ccBetaling.Uitvoeren();

            PrintHeader("[PayPal]");
            BetaalWijze ppBetaling = new PayPalBetaling();
            ppBetaling.Uitvoeren();

            PrintHeader("[PIN]");
            BetaalWijze pinBetaling = new PINBetaling();
            pinBetaling.Uitvoeren();

            Console.ReadKey();
        }

        void PrintHeader(string header)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(header);
            Console.ResetColor();
        }
    }
}
