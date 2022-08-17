using System;
using System.Collections.Generic;
using System.Text;

namespace AumentoDeSalario
{
    public static class Operacoes
    {
        //determina a faixa salarial. =  float metodo(float salario)
        public static float Percentual(float salario)
        {

            if (salario > 2000.00)
            {
                return 0.04f;
            }

            else if (salario < 400.01)
            {
                return 0.15f;

            }
            else if (salario < 800.01)
            {
                return 0.12f;

            }
            else if (salario < 1200.01)
            {
                return 0.10f;

            }
            else
            {
                return 0.07f;
            }
        }

        // calcula o reajuste = float metodo(float salario, float percenntual)
        public static float Reajuste(float salario, float percentualDeAjuste)
        {
            return salario * percentualDeAjuste;
        }

        // soma o reajuste ao salario = float metodo(float reajusteSalarial, float salario)
        public static float NovoSalario(float reajusteSalarial, float salario)
        {
            return reajusteSalarial + salario;
        }

    }
}
