using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Gerente : Imposto
    {
        public override void valeAlimentacao(double salario)
        {
            Console.WriteLine($"Desconto Gerente do vale alimentação R$ {salario * 0.15}");
        }

    }
}

