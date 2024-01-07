using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaME
{
    internal class CalculadoraFatorial
    {
        public static long CalcularFatorial(int num)
        {
            if (num < 0)
            {
                throw new ArgumentException("O fatorial não está definido para números negativos.");
            }

            if (num == 0 || num == 1)
            {
                return 1;
            }

            long resultado = 1;
            for (int i = 2; i <= num; i++)
            {
                resultado *= i;
            }

            return resultado;
        }
    }
}
