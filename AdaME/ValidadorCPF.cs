using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaME
{
    internal class ValidadorCPF
    {
        public static bool ValidarCPF(string cpf)
        {
            cpf = cpf.Replace(".", "").Replace("-", "");

            if (cpf.Length != 11 || !cpf.All(char.IsDigit))
            {
                return false;
            }

            int[] pesosPrimeiroDigito = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] pesosSegundoDigito = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            if (!ValidarDigitoVerificador(cpf, pesosPrimeiroDigito, 9) || !ValidarDigitoVerificador(cpf, pesosSegundoDigito, 10))
            {
                return false;
            }

            return true;
        }

        private static bool ValidarDigitoVerificador(string cpf, int[] pesos, int posicaoDigitoVerificador)
        {
            int soma = 0;

            for (int i = 0; i < pesos.Length; i++)
            {
                soma += int.Parse(cpf[i].ToString()) * pesos[i];
            }

            int resto = soma % 11;
            int digitoVerificador = 11 - resto;

            if (digitoVerificador >= 10)
            {
                digitoVerificador = 0;
            }

            return digitoVerificador == int.Parse(cpf[posicaoDigitoVerificador].ToString());
        }
    }
}
