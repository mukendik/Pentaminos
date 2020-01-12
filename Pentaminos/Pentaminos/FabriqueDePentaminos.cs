using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pentaminos
{
    class FabriqueDePentaminos
    {
        static public List<Pentamino> ListeDePentaminos()
        {
            List<Pentamino> liste = new List<Pentamino>();
          
            for (int i=0; i<63; i++)
            {
                liste.Add(new Pentamino());
            }

            return liste;
        }
    }
}
