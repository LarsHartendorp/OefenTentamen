using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    public class Single : IVinylSingle
    {
        // constructor
        public Single(int ranking, string title, string artist)
        {
            this.Ranking = ranking;
            this.Title = title;
            this.Artist = artist; 
        }

        //properties
        public string Artist { get; }
        public int Ranking { get; }
        public string Title { get; }


        public void Afspelen()
        {
            Console.WriteLine($"playing single {ToString()}");
        }

        public void Pauze()
        {
            Console.WriteLine("Nummer gepauzeerd");
        }

        public void Stoppen()
        {
            Console.WriteLine("Nummer gestopt");
            return;
        }

        public override string ToString()
        {
            return $"'{Title}, {Artist}, ({Ranking})'"; 
        }
    }
}
