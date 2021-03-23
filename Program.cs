using System;

namespace milhasKM
{
    class Program
    {
        static void Main(string[] args)
        {
            double m=0;
            double km=0;
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Convertendo milhas em quilômetros");
            Console.WriteLine("---------------------------------");

            Console.Write("Digite um valor: ");
            Console.ForegroundColor=ConsoleColor.DarkCyan;
            m=Convert.ToDouble(Console.ReadLine());
            Console.ResetColor();
            Console.WriteLine();
            km=(m*1.609);
            Console.Clear();
            Console.WriteLine("Pressione ENTER para ver o resultado.");
            Console.ReadKey();
            Console.ForegroundColor=ConsoleColor.DarkYellow;
            Console.WriteLine("O valor digitado é igual a "+km+" km.");
            Console.ResetColor();
            Console.Beep();
        }
    }
}
