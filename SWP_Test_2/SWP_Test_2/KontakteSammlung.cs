using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SWP_Test_2
{
    internal class KontakteSammlung
    {
        private string[] kontakte;

        public int Vergleichen(string a,string b)
        {
            return a.CompareTo(b);
        }
        public bool IstVoll()
        {
            if (kontakte[kontakte.Length- 1] != null)
            {
                return true;
            }
            return false;
        }

        public int SuchePosition(string neuerKontakt)
        {
            for(int i = 0; i < kontakte.Length; i++)
            {
                if (kontakte[i] == null || Vergleichen(kontakte[i], neuerKontakt) > 0)
                {
                    return i;
                }
            }
            return -1;
        }

        public void Verschieben(int pos)
        {
            for(int i = kontakte.Length-2; i >= 0; i--)
            {
                kontakte[i+1] = kontakte[i];

            }
            kontakte[pos] = null;
        }

        public bool Eintragen(string neuerKontakt)  
        {
            if(IstVoll() == true)
            {
                return false;
            }
            else
            {
                int pos = SuchePosition(neuerKontakt);
                Verschieben(pos);
                kontakte[pos] = neuerKontakt;
                return true;
            }


        }

    }
}
