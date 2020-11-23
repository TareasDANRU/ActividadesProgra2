using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lamda
{

    delegate int Operar(int a, int b);
    class Delegado
    {
        public int Sumar(int x, int y)
        {
            return x + y;
        }
        public int Restar(int x, int y)
        {
            return x - y;
        }


    }
}
