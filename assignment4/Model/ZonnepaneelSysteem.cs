using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment4
{
    // observable & model
    public class ZonnepaneelSysteem : IObservable
    {
        // private list maken van observers
        private List<IObserver> observers;

        // fields
        private Random random;

        public ZonnepaneelSysteem()
        {
            this.observers = new List<IObserver>();
            this.random = new Random();
        }

        // property
        public int Wattage { get; set; }

        public void Add(IObserver observer)
        {
            this.observers.Add(observer);
        }

        public void Delete(IObserver observer)
        {
            this.observers.Remove(observer);
        }

        public void NieuweMeting()
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(0,1000);
            this.Wattage = randomNumber;

            // belangrijk om de notify aan te roepen. Anders berekening gemaakt maar gebeurd niets. 
            Notify();
        }

        // notify altijd eigen methode. 
        public void Notify() 
        {
            foreach (IObserver observer in this.observers)
            {
                observer.Update(Wattage);
            }
        }
    }
}
