using System;
using System.Collections.Generic;
using System.Text;

namespace AumentoDeSalario
{
    public static class Validacao
    {
        // valida se a entrada é um numero
        public static bool ENumero(string input)
        {
            if (float.TryParse(input, out float n))
                return true;
            else
                return false;
        }

    }
}
