using System;
using System.Globalization;

namespace AumentoDeSalario
{
    public static class Tela
    {
        // recebe a entrada 
        public static string RecebeSalario()
        {
            Console.WriteLine("Informe o salario a ser calculado: ");
            return Console.ReadLine();
        }

        // imprime em tela as informações: novo salario, reajuste e percentual. = metodo(float salarioReajustado, float reajusteSalarial, float percentualDeAjuste)
        public static void ExibirValores(float salarioReajustado, float reajusteSalarial, float percentualDeAjuste)
        {
            Console.WriteLine($"Novo salario: {salarioReajustado.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Reajuste ganho: {reajusteSalarial.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Em percentual: {(percentualDeAjuste * 100).ToString("F0")}%");
        }

    }
}
