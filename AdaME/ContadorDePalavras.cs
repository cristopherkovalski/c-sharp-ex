using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaME
{
    internal class ContadorDePalavras
    {
        public static Dictionary<string, int> ContarPalavras(string texto)
        {
            string[] palavras = texto.Split(new[] { ' ', '\t', '\n', '\r', '.', ',', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> frequenciaPalavras = new Dictionary<string, int>();

            foreach (string palavra in palavras)
            {
                string palavraFormatada = palavra.ToLower();

                if (frequenciaPalavras.ContainsKey(palavraFormatada))
                {
                    frequenciaPalavras[palavraFormatada]++;
                }
                else
                {
                    frequenciaPalavras[palavraFormatada] = 1;
                }
            }

            return frequenciaPalavras;
        }
    }
}
