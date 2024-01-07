using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaME
{
    internal class ValidadorDeSenha
    {
        public static bool ValidarSenha(string senha)
        {
            if (senha.Length < 8)
            {
                return false;
            }

            if (!senha.Any(char.IsUpper) || !senha.Any(char.IsLower) || !senha.Any(char.IsDigit))
            {
                return false;
            }

            return true;
        }
    }
}
