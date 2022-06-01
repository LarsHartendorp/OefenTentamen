using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment4
{
    // view 
    public class ZonneDisplay : IObserver
    {
        // IObservable want je praat tegen de interface. 
        private IObservable systeem;


        // geeft een IObservable mee en voegt zichzelf hieraan toe. 
        public ZonneDisplay(IObservable observable)
        {
            this.systeem = observable;
            this.systeem.Add(this);
        }

        public void Update(int watt)
        {
            Console.WriteLine($"Nieuwe meting: {watt} Watt");
        }
    }
}
