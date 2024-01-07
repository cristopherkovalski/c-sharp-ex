using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaME
{
    internal class CalculadoraRaizQuadrada
    {
        public static double CalcularRaizQuadrada(double numero)
        {
            if (numero < 0)
            {
                throw new ArgumentException("Não é possível calcular a raiz quadrada de um número negativo.");
            }

            double estimativa = numero / 2; // Uma estimativa inicial razoável
            double erro = 0.0001; // Precisão desejada

            while (Math.Abs(estimativa * estimativa - numero) > erro)
            {
                estimativa = (estimativa + numero / estimativa) / 2;
            }

            return estimativa;
        }
    }
}
