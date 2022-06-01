using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    public class AlbumAdapter : IVinylSingle
    {
        private IVinylAlbum vinylAlbum;
        public void Afspelen()
        {
            this.vinylAlbum.Afspelen();
        }

        public void Pauze()
        {
            this.vinylAlbum.Pauze();
        }

        public void Stoppen()
        {
            this.vinylAlbum.Stoppen();
        }
    }
}
