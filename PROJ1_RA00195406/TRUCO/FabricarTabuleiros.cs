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
        /*public static Tabuleiro Mazemoria(List<Texture2D> textura)
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
            Tabuleiro tabuleiro = new Tabuleiro(3, 3);
            List<Carta> baralho = new List<Carta>();
            Carta[] carta;
            carta = new Carta[40];

            for (int num = 0; num < 40; num++)
            {
                carta[num] = new Carta(textura[num], num);
                baralho.Add(carta[num]);
            }

            distribuirCartas(baralho, tabuleiro);

            return tabuleiro;
        }
        
        private static void distribuirCartas(List<Carta> baralho, Tabuleiro tabuleiro)
        {
            Random rnd = new Random();
            for (int lin = 0; lin < tabuleiro.Linhas; lin++)
            {
                for (int col = 0; col < tabuleiro.Colunas; col++)
                {
                    int c = rnd.Next(0, baralho.Count);
                    Carta carta = baralho[c];
                    baralho.RemoveAt(c);
                    carta.Linha = lin;
                    carta.Coluna = col;
                    tabuleiro.Colocar(carta, lin, col);
                }
            }
        }
    }
}
