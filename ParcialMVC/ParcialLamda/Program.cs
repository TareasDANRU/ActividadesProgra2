using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialLamda
{
    class Program
    {
        static void Main(string[] DANRU)
        {
            //Ejercicio 1
            Temperatura tem = new Temperatura();
            Console.WriteLine("<<<***Temperatura de cada dia de la semana***>>>");
            double temp;
            Console.WriteLine("Ingresa la temperatura: ");
            temp = Convert.ToDouble(Console.ReadLine());
            tem.cargar(0, new Delegado { DIA = "LUNES", TEMPERATURA = Convert.ToDouble(temp) });
            Console.WriteLine("Ingresa la temperatura: ");
            temp = Convert.ToDouble(Console.ReadLine());
            tem.cargar(1, new Delegado { DIA = "MARTES", TEMPERATURA = Convert.ToDouble(temp) });
            Console.WriteLine("Ingresa la temperatura: ");
            temp = Convert.ToDouble(Console.ReadLine());
            tem.cargar(2, new Delegado { DIA = "MIERCOLES", TEMPERATURA = Convert.ToDouble(temp) });
            Console.WriteLine("Ingresa la temperatura: ");
            temp = Convert.ToDouble(Console.ReadLine());
            tem.cargar(3, new Delegado { DIA = "JUEVES", TEMPERATURA = Convert.ToDouble(temp) });
            Console.WriteLine("Ingresa la temperatura: ");
            temp = Convert.ToDouble(Console.ReadLine());
            tem.cargar(4, new Delegado { DIA = "VIERNES", TEMPERATURA = Convert.ToDouble(temp) });
            Console.WriteLine("Ingresa la temperatura: ");
            temp = Convert.ToDouble(Console.ReadLine());
            tem.cargar(5, new Delegado { DIA = "SABADO", TEMPERATURA = Convert.ToDouble(temp) });
            Console.WriteLine("Ingresa la temperatura: ");
            temp = Convert.ToDouble(Console.ReadLine());
            tem.cargar(6, new Delegado { DIA = "DOMNIGO", TEMPERATURA = Convert.ToDouble(temp) });

            tem.Promedio();

            //Ejercicio 2
            ValorFinal vf = new ValorFinal();
            Console.WriteLine("<<<***Valor final a pagar en una súper tienda***>>>");
            double total;
            Console.WriteLine("Ingresa el total de la compra: ");
           total = Convert.ToDouble(Console.ReadLine());
            vf.cargar(0, new Delegado { VALOR = Convert.ToDouble(total) });
            vf.ValorF();
            Console.ReadKey();
        }
    }
}
