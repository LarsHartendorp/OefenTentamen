using System;

namespace assignment4
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
            // create solarpanel system
            IObservable systeem = new ZonnepaneelSysteem();

            // create a controller
            IPaneelController paneelController = new PaneelController(systeem);

            // create a solarpanel display
            IObserver display = new ZonneDisplay(systeem);

            // perform a few measurements
            for (int i = 0; i < 10; i++)
                paneelController.NieuweMeting();

            Console.ReadKey();
        }
    }
}
