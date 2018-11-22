using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRUCO
{
    class DrawObjetos
    {
        public static void Botao(Botao botao, SpriteBatch sp, Texture2D textura, SpriteFont fonte)
        {
            Vector2 posLegenda = new Vector2(botao.Posicao.X + (140 - botao.Legenda.Length / 2), botao.Posicao.Y + 25);
            sp.Draw(textura, new Rectangle((int)botao.Posicao.X, (int)botao.Posicao.Y, 300, 50), Color.White); ;
            sp.DrawString(fonte, botao.Legenda, posLegenda, Color.Red);
        }
        public static void TextoNaTela(TextoNaTela help, SpriteBatch sp, SpriteFont fonte1, SpriteFont fonte2, SpriteFont fonte3)
        {
            sp.DrawString(fonte1, help.Titulo1, new Vector2(70, 20), Color.White);
            sp.DrawString(fonte1, help.Titulo2, new Vector2(180, 20), Color.LimeGreen);
            sp.DrawString(fonte2, help.Texto1, new Vector2(10, 100), Color.White);
            sp.DrawString(fonte3, help.Texto2, new Vector2(10, 100), Color.LimeGreen);

        }
        public static void TextoNaTela2(TextoNaTela about, SpriteBatch sp, SpriteFont fonte1, SpriteFont fonte2, SpriteFont fonte3)
        {
            sp.DrawString(fonte1, about.Titulo1, new Vector2(70, 20), Color.White);
            sp.DrawString(fonte1, about.Titulo2, new Vector2(200, 20), Color.LimeGreen);
            sp.DrawString(fonte2, about.Texto1, new Vector2(330, 150), Color.White);
            sp.DrawString(fonte3, about.Texto2, new Vector2(500, 150), Color.LimeGreen);

        }

        public static void Carta(Carta c, SpriteBatch sp, Texture2D texturaCoberta, List<Texture2D> texturaDescoberta, SpriteFont fonte)
        {
            int largura = 65;
            int altura = 110;
            int espaco = 14;

            Rectangle rect = new Rectangle(c.Coluna * largura + (c.Coluna + 1) * espaco,
                                           c.Linha * altura + (c.Linha + 1) * espaco,
                                            largura, altura);

            if (c.Coberta)
            {
                sp.Draw(texturaCoberta, rect, Color.White);
            }
            else
            {
                sp.Draw(c.Textura, rect, Color.White);
                Vector2 posLegenda = new Vector2(rect.X + 20, rect.Y + 40);
                //sp.DrawString(fonte, c.Textura, posLegenda, Color.OrangeRed);

            }
        }

        public static void Tabuleiro(Tabuleiro tabuleiro, SpriteBatch sp, Texture2D textura1, List<Texture2D> textura2, SpriteFont fonte)
        {
            if (tabuleiro != null)
            {
                for (int lin = 0; lin < tabuleiro.Linhas; lin++)
                {
                    for (int col = 0; col < tabuleiro.Colunas; col++)
                    {
                        Carta carta = tabuleiro.GetCarta(lin, col);
                        if (carta != null)
                        {
                            DrawObjetos.Carta(carta, sp, textura1, textura2, fonte);
                        }
                    }
                }
            }
        }


    }
}
