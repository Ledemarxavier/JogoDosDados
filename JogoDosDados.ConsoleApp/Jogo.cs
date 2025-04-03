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
        public const int posicaoFinal = 30;
        public int posicaoJogador = 0;
        public int posicaoComputador = 0;
        public Random geradorDeNumeros = new Random();

        public void Iniciar()
        {
            while (!FinalDoJogo()) // Continua o jogo enquanto nenhum dos jogadores atingir a posição final.
            {
                Console.Clear();
                Mensagens.ExibirCabecalho();
                VezDoJogador(); // Jogador realiza sua jogada
                if (FinalDoJogo())
                    break;
                VezDoComputador(); // Computador realiza sua jogada
                Console.ReadLine();
            }
            ExibirVencedor();
            Console.ReadLine();
        }

        public int LancarDado()
        {
            return geradorDeNumeros.Next(1, 7);
        }

        public void VezDoJogador()
        {
            Console.Write("\nPressione ENTER para lançar o dado...");
            Console.ReadLine();
            int resultado = LancarDado();
            Mensagens.ExibirValorSorteado(resultado);
            AtualizarPosicao(ref posicaoJogador, resultado);
            Mensagens.ExibirPosicaoJogador(posicaoJogador);
            Console.ReadLine();
        }

        public void VezDoComputador()
        {
            Console.Clear();
            Mensagens.ExibirCabecalho();
            Console.WriteLine("\nVez do Computador...");
            int resultado = LancarDado();
            Mensagens.ExibirValorSorteado(resultado);
            AtualizarPosicao(ref posicaoComputador, resultado);
            Console.WriteLine($"Posição do Computador: {posicaoComputador}");
        }

        public void ExibirVencedor()
        {
            Console.Clear();
            Mensagens.ExibirCabecalho();
            if (posicaoJogador >= posicaoFinal)
            {
                Console.WriteLine("Parabéns! Você venceu!");
            }
            else if (posicaoComputador >= posicaoFinal)
            {
                Console.WriteLine("O Computador venceu! Boa sorte na próxima vez.");
            }
        }

        public void AtualizarPosicao(ref int posicao, int valor)
        {
            posicao += valor;
            EventosEspeciais(ref posicao); // Atualiza a posição do jogador e aplica eventos especiais, se houver.
        }

        public void EventosEspeciais(ref int posicao)
        {
            if (posicao == 5 || posicao == 10 || posicao == 15) //Se um dos jogadores parar nas posições 5, 10 ou 15 ele avança três casas.
            {
                Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("    Bônus avançou 3 casas!    ");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                posicao += 3; //Aumenta a posição.
            }
            else if (posicao == 7 || posicao == 13 || posicao == 20) //Se um dos jogadores parar nas posições 7, 13 ou 20 ele recua duas casas.
            {
                Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine(" Penalidade! Recuou -2 casas! ");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                posicao -= 2; //Diminui a posição
            }
        }

        public bool FinalDoJogo()
        {
            return posicaoJogador >= posicaoFinal || posicaoComputador >= posicaoFinal;
        }
    }
}