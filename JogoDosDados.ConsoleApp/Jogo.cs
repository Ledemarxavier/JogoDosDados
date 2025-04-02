using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace JogoDosDados.ConsoleApp
{
    internal class Jogo
    {
        public void Jogar()
        {
            while (true)
            {
                Mensagens.ExibirCabecalho();
                Console.Write("Pressione ENTER para lançar o dado...");
                Console.ReadLine();
                int resultado = LancarDado(); //adiciona o numero gerado ao resultado
                Mensagens.ExibirValorSorteado(resultado);

                if (!DesejaContinuar())
                    break;
            }
        }

        public static int LancarDado()
        {
            Random geradorDeNumeros = new Random();
            return geradorDeNumeros.Next(1, 7);
        }

        public bool DesejaContinuar()
        {
            Console.WriteLine("\nDeseja Continuar (S/N)");
            return Console.ReadLine().ToUpper() == "S";
        }
    }
}