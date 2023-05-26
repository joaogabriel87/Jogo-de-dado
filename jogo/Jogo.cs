using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jogo_de_dado.jogo
{
    public class Jogo
    {
        public string player1;
        public string player2;
        public int pontoPlayer1 = 0;
        public int pontoPlayer2 = 0;
        public int rodadaAtual = 0;

        public void AtualizarPlacar()
        {
            Console.Clear();
            Console.WriteLine($"### Pontos do jogador {player1}: {pontoPlayer1}");
            Console.WriteLine($"### Pontos do jogador {player2}: {pontoPlayer2}");
            Console.WriteLine();

            if (rodadaAtual == 0)
            {
                Console.WriteLine("### Jogo não iniciado");
            }
        }
        public int JogarDado()
        {
            Random random = new Random();
            return random.Next(1,6);
        }
        public void IniciarRodada()
        {
            AtualizarPlacar();
            if(rodadaAtual ==3)
            {
                Console.WriteLine("O jogo foi finalizado");
                return;
            }

            rodadaAtual ++;

            Console.WriteLine($"Rodada {rodadaAtual} iniciada!!! \n");

            Console.WriteLine($"Jogador {player1}, Pressione ENTER para fazer sua jogada");
            Console.ReadLine();
            int valorDado1 = JogarDado();
            Console.WriteLine($"O valor tirado pelo {player1}: {valorDado1}");

            Console.WriteLine($"Jogador {player2}, Pressione ENTER para fazer sua jogada");
            Console.ReadLine();
            int valorDado2 = JogarDado();
            Console.WriteLine($"O valor tirado pelo {player2}: {valorDado2}");

            if (valorDado1 ==  valorDado2)
            {
                Console.WriteLine($"\n{player1} tirou o numero {valorDado1} e {player2} o numero {valorDado2}. EMPATE!!");
                Console.WriteLine("Pressione ENTER para continuar");
                Console.ReadLine();
            }
            else
            {
                string vencedor;

                if(valorDado1 > valorDado2)
                {
                    vencedor = player1;
                    pontoPlayer1++;
                }
                else
                {
                    vencedor = player2;
                    pontoPlayer2++;
                }
                Console.WriteLine($"\n {player1} tirou o numero {valorDado1} e {player2} o numero {valorDado2}. {vencedor} venceu a rodada {rodadaAtual}");
                Console.WriteLine("Pressione ENTER para continuar");
                Console.ReadLine();
            }
            IniciarRodada();
        }
        public void FinalizarJogo()
        {
            AtualizarPlacar();
            Console.WriteLine("JOGO FINALIZADO!!");

            if (pontoPlayer1 > pontoPlayer2)        
            {
                Console.WriteLine($"O jogador {player1} venceou o jogo com {pontoPlayer1} pontos");
            }
            else if (pontoPlayer2 > pontoPlayer1)
            {
                 Console.WriteLine($"O jogador {player2} venceou o jogo com {pontoPlayer2} pontos");
            }
            else
            {
                Console.WriteLine("EMPATE!!!");
            }
        }
        }
    }
