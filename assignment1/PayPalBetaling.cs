using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    public class PayPalBetaling : BetaalWijze
    {
        public override void VerwerkenOpdracht()
        {
            Console.WriteLine("PayPal betaling verwerken...");
        }

    }
}
