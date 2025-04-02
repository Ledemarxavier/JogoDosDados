using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDosDados.ConsoleApp
{
    internal class Mensagens
    {
        public static void ExibirCabecalho()
        {
            Console.Clear();
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Jogo dos Dados");
            Console.WriteLine("----------------------------------");
        }

        public static void ExibirValorSorteado(int resultado)
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"O valor sorteado foi: {resultado}!");
            Console.WriteLine("----------------------------------");
        }
    }
}