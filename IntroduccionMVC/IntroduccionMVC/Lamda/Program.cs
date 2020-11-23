using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lamda
{
    class Program
    {
        static void Main(string[] args)
        {
            Delegado dlg = new Lamda.Delegado();
            //Programacion 1
            Console.WriteLine("Resultados");
            Console.WriteLine(dlg.Sumar(2, 5));
            Console.WriteLine(dlg.Restar(2, 5));
            //Fin Programacion 1

            //Delegado Programacion 2
            Operar delegadoSumar = dlg.Sumar;
            Console.WriteLine(delegadoSumar(5, 6));
            Operar delegadoRestar = dlg.Restar;
            Console.WriteLine(delegadoRestar(5, 6));
            //Fin delegado
            //Lamda Programacion 2

            
            var suma = Delegado2.operacion(10, 3, (x, y) => { return x + y; });
            Console.WriteLine("La suma de 10 y 3 es {0}", suma);
            var resta = Delegado2.operacion(10, 3, (x, y) => { return x - y; });
            Console.WriteLine("La resta de 10 y 3 es {0}", resta);
            var multiplicacion = Delegado2.operacion(10, 3, (x, y) => { return x * y; });
            Console.WriteLine("La multiplicacion de 10 y 3 es {0}", multiplicacion);
            //Fin Lamda Programacion 2


            Materia mat = new Materia();
            mat.cargar(0, new Delegado3 { NOMBRE = "JUAN", NOTA = 9 });
            mat.cargar(1, new Delegado3 { NOMBRE = "MARIA", NOTA = 10 });
            mat.cargar(2, new Delegado3 { NOMBRE = "PEDRO", NOTA = 7 });
            mat.cargar(3, new Delegado3 { NOMBRE = "KARLA", NOTA = 2 });
            mat.cargar(4, new Delegado3 { NOMBRE = "MARIO", NOTA = 3 });

            Console.WriteLine("*************************");
            Console.WriteLine("Mostrar todos");
            mat.imprimirTodos();
            Console.WriteLine("*************************");
            Console.WriteLine("Mostrar mayores de 7");
            mat.ImprimirCondicion((nota)=> nota >= 7);
            Console.WriteLine("*************************");
            Console.WriteLine("Mostrar menores de 7");
            mat.ImprimirCondicion((nota) => nota < 7);
            Console.ReadKey();
        }
    }
}
