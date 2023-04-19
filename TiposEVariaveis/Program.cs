using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposEVariaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 10; // // Declara uma variável inteira e armazena o valor 10 nela
            int numero2 = 20;
            var soma = numero1 + numero2; // O var define dinâmicamente o tipo de variável

            Console.WriteLine("10 + 20 = " + soma);

            int copiaDeNumero1 = numero1; // Copia o valor da variável 'numero1'
            copiaDeNumero1 = 11;

            Console.WriteLine(numero1);
            Console.WriteLine(copiaDeNumero1);

            var quadrado1 = new Quadrado(); // Cria um quadrado
            quadrado1.lado = 10; // Quadrado1 terá valor de lado = 10
            var quadrado2 = quadrado1; // Ambas apontam o dado no mesmo lugar da memória, quando altera um, altera o outro
            quadrado2.lado = 11;

            Console.WriteLine(quadrado1.lado); // O valor fica 11
            Console.WriteLine(quadrado2.lado); // O valor fica 11
        }

        class Quadrado // Define classe chamada Quadrado
        {
            public int lado; // Define um atributo chamado lado
        }
    }
}
