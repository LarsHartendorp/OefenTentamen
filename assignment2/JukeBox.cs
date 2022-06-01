using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    public class JukeBox
    {
        private List<IVinylSingle> vinylSingles;
        private IVinylSingle vinylSingle;
        // lijst van IVinylSingles meegeven?        
        public JukeBox(List<IVinylSingle> vinylSingles)
        {
            this.vinylSingles = vinylSingles;
            this.vinylSingle = this.vinylSingles.First();
        }

        // vier methodes incl constructor. 
        public void Afspelen() 
        {
            this.vinylSingle.Afspelen();
        }
        
        // single.count moet ik nog ff fixen. 
        public void SelectSingle(int index) 
        {
            this.vinylSingle = this.vinylSingles[index];
        }

        public void Stoppen() 
        {
            this.vinylSingle.Stoppen();
        }
    }
}
