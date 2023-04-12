﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Imposto
    {
        public virtual void valeAlimentacao(double salario)
        {
            Console.WriteLine($"Desconto padrão do vale alimentação R$ {salario * 0.1}");
        }
        public virtual void valeTransporte(double transporte)
        {
            Console.WriteLine($"Desconto padrão do vale transporte R$ {transporte * 0.06}");
        }
    }

}
