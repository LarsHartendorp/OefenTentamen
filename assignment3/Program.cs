using System;

namespace assignment3
{
    class Program
    {
        // Singleton pattern. één kopiermachine!
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }

        void Start()
        {
            // twee machines, alleen machine1 zal werken. 
            KopieerMachine machine1 = KopieerMachine.GetInstance();
            KopieerMachine machine2 = KopieerMachine.GetInstance();
            Console.WriteLine("kopieren met 'machine 1'");
            machine1.Kopieren(10);
            machine1.Kopieren(23);
            Console.WriteLine("kopieren met 'machine 2'");
            machine2.Kopieren(40);


        }
    }
}
