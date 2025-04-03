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
            Console.WriteLine("************************************");
            Console.WriteLine("********* Jogo dos Dados ***********");
            Console.WriteLine("************************************");
        }

        public static void ExibirValorSorteado(int resultado)
        {
            Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine($"  O valor sorteado foi: {resultado}!  ");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        }

        public static void ExibirPosicaoJogador(int posicaoJogador)
        {
            Console.WriteLine($"Sua posição: {posicaoJogador}");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        }

        public static void ExibirPosicaoComputador(int posicaoComputador)
        {
            Console.WriteLine($"Sua posição: {posicaoComputador}");
        }
    }
}