using System;
using Jogo_de_dado.jogo;

Jogo a = new Jogo();
 Console.WriteLine("Sejam bem-vindo ao jogo!!");
 Console.WriteLine("Para iniciar digite o nome dos participantes");
 a.player1 = Console.ReadLine();
 a.player2 = Console.ReadLine();

 Console.WriteLine($"\n Jogadores {a.player1} e {a.player2} criados. Pressione qualquer tecla para iniciar.");
 Console.ReadLine();

 a.IniciarRodada();

 a.FinalizarJogo();