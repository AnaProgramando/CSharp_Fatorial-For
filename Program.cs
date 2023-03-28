using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_FatorialFor
{
    class Program
    {
        static void Main(string[] args)
        {
            int fatorial = 1;

            Console.WriteLine("Executando Projeto - Fatorial com For: \r\n");
                        
            for (int contador = 1; contador < 11; contador++)
            {
                fatorial *= contador;
                Console.WriteLine("O fatorial de " + contador + " = " + fatorial);
            }
            Console.ReadLine();
        }
    }
}
