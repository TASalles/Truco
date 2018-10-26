using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesPrivate
{
    class DrawObjetos
    {
        public static void Botao(Botao botao, SpriteBatch sp, Texture2D textura, SpriteFont font )
        {
            Vector2 PosLegenda = new Vector2(botao.Posicao.X + (140 - botao.Legenda.Length / 2), botao.Posicao.Y + 25);
            sp.Draw(textura, new Rectangle((int)botao.Posicao.X, (int)botao.Posicao.Y, 300, 50), Color.White);
            sp.DrawString(font, botao.Legenda, PosLegenda, Color.Red);
        }
    }
}
