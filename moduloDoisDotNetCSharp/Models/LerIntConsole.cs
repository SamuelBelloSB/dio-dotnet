using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace moduloDoisDotNetCSharp.Models
{
    public class LerIntConsole
    {
        public static int LerIntDoConsole()
        {
            int valor;
            while (true)
            {
                string? entrada = Console.ReadLine();
                if (int.TryParse(entrada, out valor))
                {
                    return valor;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, insira um número inteiro.");
                }
            }
        }
    }
}