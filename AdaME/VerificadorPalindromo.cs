using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaME
{
    internal class VerificadorPalindromo
    {
        public static bool VerificarPalindromo(string palavra)
        {
            palavra = palavra.ToLower(); // Converter para minúsculas para evitar problemas de case

            int inicio = 0;
            int fim = palavra.Length - 1;

            while (inicio < fim)
            {
                if (palavra[inicio] != palavra[fim])
                {
                    return false;
                }

                inicio++;
                fim--;
            }

            return true;
        }
    }
}
