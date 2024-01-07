using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaME
{
    internal class ConversorDeMoeda
    {
        public static double ConverterRealParaDolar(double valorEmReais, double cotacaoDolar)
        {
            if (valorEmReais < 0 || cotacaoDolar <= 0)
            {
                throw new ArgumentException("Os valores devem ser positivos.");
            }

            return valorEmReais / cotacaoDolar;
        }

    }
}
