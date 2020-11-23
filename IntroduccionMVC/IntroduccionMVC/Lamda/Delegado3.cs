using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lamda
{
    public delegate bool compara(int dato);
    class Delegado3
    {
        public string NOMBRE { get; set; }
        public int NOTA { get; set; }
    }

    class Materia
    {
        private Delegado3[] vector = new Delegado3[5];

        public void cargar(int posic, Delegado3 nombre)
        {
            vector[posic] = nombre;
        }
        public void imprimirTodos()
        {
            foreach (var elm in vector)
            {
                Console.WriteLine("Nombre: {0} Nota:{1}", elm.NOMBRE, elm.NOTA);
            }
        }
        public void ImprimirCondicion(compara comp)
        {
            foreach (var elm in vector)
            {
                if (comp(elm.NOTA))
                {
                    Console.WriteLine("Nombre: {0} Nota:{1}", elm.NOMBRE, elm.NOTA);
                }
            }
        }
    }
}
