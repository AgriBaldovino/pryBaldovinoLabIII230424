using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryBaldovino20230424
{
    internal class clsConfig
    {
        public static string getCadena()
        {
            string cadena = "provider=microsoft.jet.oledb.4.0;data source=CLIMA.mdb";
            return cadena;
        }
    }
}
