using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LacosCondicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Laços Condicionais => Execução mediante  determinada condição/situação
            int hora = 18;

            // Laço if, else if e else

            if (hora <= 15) // Se a hora for menor ou igual a 15, será impressa a mensagem no console
                Console.WriteLine("São menos que 15h!");
            else if (hora <= 17)
                Console.WriteLine("A hora é menor ou igual a 17h!");
            else // O else garante a execução do bloco de código seguinte a ele
            {
                if (hora == 18)
                    Console.WriteLine("São 18h!");
                else
                    Console.WriteLine("Já passou das 18h!");
            }

            // Switch.. case
            // Geralmente a expressão avaliada é uma constante
            switch (hora)
            {
                case 15: // O teste condicional aqui é exato
                    Console.WriteLine("São 15h!");
                    break;
                case 18: // O teste condicional aqui é exato
                    Console.WriteLine("São 18!");
                    break;
            }

            PrimeiroSemestre mes = PrimeiroSemestre.Maio;
            switch (mes)
            {
                case PrimeiroSemestre.Janeiro:
                    Console.WriteLine("Estamos em Janeiro!");
                    break;
                case PrimeiroSemestre.Fevereiro:
                    Console.WriteLine("Estamos em Fevereiro!");
                    break;
                case PrimeiroSemestre.Marco:
                    Console.WriteLine("Estamos em Março!");
                    break;
                default: // Será executado se nenhum dos outros for satisfeito
                    Console.WriteLine("O mês atual não é nem Janeiro, Fevereiro ou Março! É " + mes);
                    break;
            }
        }
    }

    public enum PrimeiroSemestre
    {
        Janeiro, Fevereiro, Marco, Abril, Maio, Junho
    }
}
