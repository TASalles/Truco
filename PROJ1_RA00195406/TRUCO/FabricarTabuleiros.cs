using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRUCO
{
    class FabricarTabuleiros
    {
        /*public static Tabuleiro Mazemoria(List<Texture2D> textura) // JOGO ANTIGO, REFERENCIA
        {
            Tabuleiro tabuleiro = new Tabuleiro(2, 10);
            List<Carta> baralho = new List<Carta>();
            Carta carta1;
            Carta carta2;

            for (int num = 0; num < 10; num++)
            {
                carta1 = new Carta(textura[num], num);
                carta2 = new Carta(textura[num], num);
                baralho.Add(carta1);
                baralho.Add(carta2);
            }

            distribuirCartas(baralho, tabuleiro);

            return tabuleiro;
        }*/

        public static Tabuleiro Truco(List<Texture2D> textura)
        {
            Tabuleiro[] tabuleiros;
            tabuleiros = new Tabuleiro[3];
            List<Tabuleiro> Mesa = new List<Tabuleiro>();

            tabuleiros[0] = new Tabuleiro(1, 1); // DECK
            tabuleiros[1] = new Tabuleiro(1, 3); // JOGADOR 1
            tabuleiros[2] = new Tabuleiro(1, 3); // JOGADOR 2
            

            List<Carta> baralho = new List<Carta>();
            Carta[] carta;

            carta = new Carta[40];
            carta[0] = new Carta(textura[0], 0, 4); // CARTA NULA | VERSO CARTA | PLACEHOLDER

            for (int num = 1; num < 40; num++)
            {
                carta[num] = new Carta(textura[num], num % 10, num % 4); // CRIA E ADICIONA A CARTA NO ARRAY DE CARTAS COM O VALOR DIVIDIDO POR 10 E ATRIBUI UM DOS 4 NAIPES
                baralho.Add(carta[num]);
            }

            distribuirCartas(baralho, tabuleiros[0]);

            return tabuleiros[0];
        }
        //DISTRIBUIR CARTAS NOS TABULEIROS MESA, JOGADOR E INIIMIGO
        private static void distribuirCartas(List<Carta> baralho, Tabuleiro tabuleiros)
        {
            Random rnd = new Random();
            for (int lin = 0; lin < tabuleiros.Linhas; lin++)
            {
                for (int col = 0; col < tabuleiros.Colunas; col++)
                {
                    int c = rnd.Next(0, baralho.Count);
                    Carta carta = baralho[c];
                    baralho.RemoveAt(c);
                    carta.Linha = lin;
                    carta.Coluna = col;
                    tabuleiros.Colocar(carta, lin, col);
                }

            }/*
            for (int lin = 0; lin < tabuleiro2.Linhas; lin++)
            {
                for (int col = 0; col < tabuleiro2.Colunas; col++)
                {
                    int c = rnd.Next(0, baralho.Count);
                    Carta carta = baralho[c];
                    baralho.RemoveAt(c);
                    carta.Linha = lin;
                    carta.Coluna = col;
                    tabuleiro2.Colocar(carta, lin, col);
                }
            }
            for (int lin = 0; lin < tabuleiro3.Linhas; lin++)
            {
                for (int col = 0; col < tabuleiro3.Colunas; col++)
                {
                    int c = rnd.Next(0, baralho.Count);
                    Carta carta = baralho[c];
                    baralho.RemoveAt(c);
                    carta.Linha = lin;
                    carta.Coluna = col;
                    tabuleiro3.Colocar(carta, lin, col);
                }
            }
            */
        }
    }
}
