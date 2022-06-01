using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment4
{
    // controller
    public class PaneelController : IPaneelController
    {
        private IObservable zonnepaneel;

        public PaneelController(IObservable zonnepaneel)
        {
            this.zonnepaneel = zonnepaneel;
        }

        public void NieuweMeting()
        {
            this.zonnepaneel.NieuweMeting();
        }
    }
}
