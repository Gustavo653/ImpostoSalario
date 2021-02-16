using ImpostoSalario.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpostoSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira seu salário bruto: ");
            double salario = double.Parse(Console.ReadLine());
            Impostos impostos = new Impostos(salario);

            Console.WriteLine();
            Console.WriteLine("Seu salário bruto: " + salario);
            Console.WriteLine("O valor do seu fgts é: " + impostos.CalcularFgts(salario).ToString());
            Console.WriteLine("O valor do seu vale é: " + impostos.CalcularVale(salario).ToString());
            Console.WriteLine("O valor do seu inss é: " + impostos.CalcularInss(salario).ToString());
            Console.WriteLine("O valor do seu ir é: " + impostos.CalcularIr(salario).ToString());
            Console.WriteLine("Seu salário é: " + impostos.CalcularSalario(salario).ToString());

            Console.ReadKey();
        }
    }
}
