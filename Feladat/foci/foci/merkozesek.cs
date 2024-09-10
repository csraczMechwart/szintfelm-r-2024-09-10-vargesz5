using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foci
{
    internal class merkozesek
    {
        public merkozesek(int fordulo, int hazaigol, int vendeggol, int hazaifelidogol, int vendegfelidogol, string hazainev, string vendegnev)
        {
            Fordulo = fordulo;
            Hazaigol = hazaigol;
            Vendeggol = vendeggol;
            Hazaifelidogol = hazaifelidogol;
            Vendegfelidogol = vendegfelidogol;
            Hazainev = hazainev;
            Vendegnev = vendegnev;
        }

        public int Fordulo { get; set; }
        public int Hazaigol { get; set; }
        public int Vendeggol { get; set; }
        public int Hazaifelidogol { get; set; }
        public int Vendegfelidogol { get; set; }
        public string Hazainev { get; set; }
        public string Vendegnev { get; set; }
    }
}
