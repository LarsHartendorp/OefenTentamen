using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    public class Album : IVinylAlbum
    {
        //<title;band;year>
        public Album(string title, string band, int year)
        {
            this.Title = title;
            this.Band = band;
            this.Year = year;
        }
        public string Title { get; }
        public string Band { get; }
        public int Year { get; }

        public void Afspelen()
        {
            Console.WriteLine($"playing album {ToString()}");
        }

        public void Pauze()
        {
            Console.WriteLine("Album wordt gepauzeerd");
        }

        public void Stoppen()
        {
            Console.WriteLine("Album gestopt");
            return;
        }
        public override string ToString()
        {
            return $"'{Title}, {Band} ({Year})'";
        }
    }
}
