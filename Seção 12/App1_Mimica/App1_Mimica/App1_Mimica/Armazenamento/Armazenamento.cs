using System;
using System.Collections.Generic;
using System.Text;
using App1_Mimica.Model;


namespace App1_Mimica.Armazenamento
{
    public class Armazenamento
    {
        public static Jogo Jogo { get; set; }
        public static short RodadaAtual { get; set; }

        public static string[][] Palavras =
        {
            //Fáceis Pontuação 1
            new string [] {"Olho", "Língua", "Chinelo","Milho", "Penalti", "Bola", "Ping-pong"},
            //Médio Pontuação 3
            new string [] {"Carpinteiro","Amarelo", "Limão","Abelha"},
            //Difíceis Pontuação 5
            new string [] {"Cisterna","Lanterna", "Batman vs Superman","Notebook"}
        };
    }
}
