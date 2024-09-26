using Comex.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Comex.Testes
{
    internal class TestaVestuario
    {
        static Vestuario blusa = new Vestuario("Blusa", "Blusa feminina de viscose", 69.90, 10,"Roupas Femininas", "tamanho: M;cor: Rosa");

        public static void ExibeVestuario()
        {
            Console.WriteLine($"Tamanho: {blusa.Tamanho}");
            Console.WriteLine($"Cor: {blusa.Cor}");
            Console.ReadKey();
        }
    }
}
