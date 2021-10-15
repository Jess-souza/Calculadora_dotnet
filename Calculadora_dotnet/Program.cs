using System;

namespace Calculadora_dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1;
            double n2;
            double resultado;

            Console.WriteLine("Digite o primeiro número: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            n2 = Convert.ToDouble(Console.ReadLine());

            resultado = n1 + n2;
            Console.WriteLine("O resultado da minha soma é: {0}", resultado);


        }
    }
}
