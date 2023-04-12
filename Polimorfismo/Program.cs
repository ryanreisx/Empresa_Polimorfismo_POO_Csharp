using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Imposto gerente = new Gerente();
            gerente.valeAlimentacao(5000);
            gerente.valeTransporte(5000);
            Console.WriteLine("----------------------------");   
            Imposto atendente = new Atendente();
            atendente.valeAlimentacao(2000);
            atendente.valeTransporte(2000);  
            Console.WriteLine("----------------------------");
            Imposto estagiario = new Estagiario();
            estagiario.valeTransporte(1000);
            estagiario.valeAlimentacao(1000);
            Console.WriteLine("----------------------------");
            Console.ReadLine();


        }
    }
}
