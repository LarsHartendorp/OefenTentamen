using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    public abstract class BetaalWijze
    {
        // dit is het skelet. Dit moet gebeuren en iedere class neemt dit over. 
        public void Uitvoeren()
        {
            GegevensInvoeren();
            VerwerkenOpdracht();
            BevestigingsMail();
        }

        // bij iedere abstract class is "betaling verwerken" duplicate code. Kan dit beter?
        public void GegevensInvoeren() 
        {
            Console.WriteLine("invoeren van gegevens...");
        }

        public abstract void VerwerkenOpdracht();

        public void BevestigingsMail() 
        {
            Console.WriteLine("bevestigingsmail versturen...");
        }
    }
}
