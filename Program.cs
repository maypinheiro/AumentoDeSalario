using System;
using System.Globalization;

namespace AumentoDeSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Tela.RecebeSalario();
            if (Validacao.ENumero(input))
            {
                var salarioAtual = float.Parse(input, CultureInfo.InvariantCulture);
                var percentual = Operacoes.Percentual(salarioAtual);
                var reajuste = Operacoes.Reajuste(salarioAtual, percentual);
                var novoSalario = Operacoes.NovoSalario(reajuste, salarioAtual);
                Tela.ExibirValores(novoSalario,reajuste,percentual);
            }
            else
                Console.WriteLine("favor informar um salario valido");
        }
    } 
}