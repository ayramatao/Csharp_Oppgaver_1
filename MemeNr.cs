using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oppgaver
{
    class MemeNr
    {
        private int favoritnummer;

        public MemeNr(int etFavoritnummer)
        {
            favoritnummer = etFavoritnummer;
        }

        public int Favoritnummer
        {
            get { return favoritnummer; }
            set { favoritnummer = value; }
        }

    }
}
