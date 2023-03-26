using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eajuste_salarial
{
    class Program
    {
        static void Main(string[] args)
        {
            calculo cal = new calculo();
            Double Salario;

            Console.WriteLine("Informe o seu salário, use ponto");

            Console.Write("Salario: ");
            double.TryParse(Console.ReadLine(), out Salario);

            Console.WriteLine();

            Console.Write("Salário atual: ");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(Salario.ToString());

            Console.ResetColor();
            Console.WriteLine();

            Console.WriteLine("\a");

            Console.Write("Novo salário: ");
            Console.ForegroundColor = ConsoleColor.Green;

            Console.Write(cal.CalculaSalario(Salario));

            Console.ReadKey();
        }

    }
}