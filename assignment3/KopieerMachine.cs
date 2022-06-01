using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    public class KopieerMachine
    {
        // static instance maken
        private static KopieerMachine instance;
        private int aantalKopies;

        // private constructor
        private KopieerMachine()
        {

        }

        public int AantalKopies 
        {
            get { return aantalKopies; }
        }

        public static KopieerMachine GetInstance()
        {
            if (instance == null)
            {
                instance = new KopieerMachine();
            }
            return instance;
        }

        public void Kopieren(int aantalKopie)
        {
            Console.WriteLine($"aan het kopieren, {aantalKopie}x");
            this.aantalKopies += aantalKopie;
            Console.WriteLine($"totaal kopies: {this.aantalKopies}x");
        }
    }
}
