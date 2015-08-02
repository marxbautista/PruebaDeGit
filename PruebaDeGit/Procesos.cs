using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaDeGit
{
    class Procesos
    {
        public void fibonacci()
        {

        }
        public void otraSerie()
        {

        }
        public String pares(int inicio, int fin)
        {
            StringBuilder cadena = new StringBuilder();
            for (int i = inicio; i < fin; i+=2)
            {
                cadena.Append(i + "-");
            }
            return cadena.ToString();
        }
    }
}
