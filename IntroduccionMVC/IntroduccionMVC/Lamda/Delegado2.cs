using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lamda
{
    delegate int Operar2(int a, int b);
    class Delegado2
    {
        public static int operacion(int x, int y, Operar2 delg2)
        {
            return delg2(x, y);
        }
    }
}
