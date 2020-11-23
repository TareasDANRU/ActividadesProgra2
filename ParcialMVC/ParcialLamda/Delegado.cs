using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialLamda
{
    public delegate bool compara(double dato);
    class Delegado
    {
        public string DIA { get; set; }
        public double TEMPERATURA { get; set; }
        public double VALOR { get; set; }
        
    }
    class Temperatura
    {
        private Delegado[] vector = new Delegado[7];
        public void cargar(int posic, Delegado nombre)
        {
            vector[posic] = nombre;
        }
        public void imprimirTodos()
        {
            foreach (var elm in vector)
            {
                Console.WriteLine("Dia: {0} Temperatura: {1}", elm.DIA, elm.TEMPERATURA);
            }
        }
        public void ImprimirCondicion(compara comp)
        {
            foreach (var elm in vector)
            {
                if (comp(elm.TEMPERATURA))
                {
                    Console.WriteLine("Dia: {0} Temperatura: {1}", elm.DIA, elm.TEMPERATURA);
                }
            }
        }
        public void Promedio()
        {
            foreach (var elm in vector)
            {
                double [] temperaturas= { elm.TEMPERATURA};
                double sumatoria = 0;
                foreach (double temperatura in temperaturas)
                {
                    sumatoria += temperatura;
                }
                double promedio = sumatoria / temperaturas.Length;
                Console.WriteLine("Temperatura promedio: {0}", promedio);
                if (promedio > 35)
                {
                    Console.WriteLine("\"Que semana tan calurosa\"");
                }
                else if (promedio >= 15 && promedio <= 35)
                {
                    Console.WriteLine("\"Que clima tan delicioso\"");
                }
                else
                {
                    Console.WriteLine("\"Que semana tan fría\"");
                }
            }            
        }
    }
    class ValorFinal
    {
        private Delegado[] vector = new Delegado[1];
        public void cargar(int posic, Delegado nombre)
        {
            vector[posic] = nombre;
        }
        public void imprimirTodos()
        {
            foreach (var elm in vector)
            {
                Console.WriteLine("Valor: {0}", elm.VALOR);
            }
        }
        public void ValorF()
        {
            foreach (var elm in vector)
            {
                double[] valor = { elm.VALOR };
                double desc;   
                if (valor [0] >= 10000 && valor [0] <=20000)
                {
                    desc = 0.1;
                    valor[0] = valor[0] - (desc * valor[0]);
                }
                else if (valor[0] > 20000 && valor[0] <= 50000)
                {
                    desc = 0.3;
                    valor[0] = valor[0] - (desc * valor[0]);
                }
                else if(valor[0] <= 50000)
                {
                    desc = 0.5;
                    valor[0] = valor[0] - (desc * valor[0]);
                }
                Console.WriteLine("Valor: {0}", valor[0]);
            }
        }
    }

}
