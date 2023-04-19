using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LacosInterativos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Laços interativos => Estruturas que repetem determinado bloco de código, determinado número de vezes

            // Laço For
            for(int i=0; i<5; i++) // 1++ significa que 1 será incrementado de 1 a 1
            { 
               Console.WriteLine("Valor de i é " + i);
            }

            // While
            int contador = 3;
            while(contador < 10) 
            {
                Console.WriteLine(contador);
                contador++;
            }

            // Do .. While
            // Execção garantida pelo menos 1 vez (Executa o bloco primeiro depois faz o teste de condição
            double j = 10;
            do
            {
                Console.WriteLine(j);
                j = j * 1.5;
            } while(j < 100);

            // Foreach
            // Percorre todos os elementos de um conjuntoint
            int[] conjunto = { 1, 2, 3, 7, };
            foreach(int numero in conjunto) 
            {
                Console.WriteLine("Esse elemento do conjunto tem valor " + numero + "! Somando esse valor a 10 temos " + (numero+10));
            }
        }
    }
}
