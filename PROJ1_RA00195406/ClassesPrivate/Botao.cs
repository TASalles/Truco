using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesPrivate
{
    class Botao
    {

        private string legenda;
        private bool clicado;
        private Vector2 posicao;

        public Botao(string leg, Vector2 pos)
        {
            this.clicado = false;
            this.legenda = leg;
            this.posicao = pos;
        }

        public Vector2 Posicao
        {
            get { return posicao; }
        }

        public string Legenda
        {
            get { return legenda; }
        }

        public bool Clicado
        {
            get { return clicado; }
        }

        public bool VerificarClique(int x, int y)
        {
            bool ok = false;

            if (y < (posicao.Y) && x < (posicao.X + 200) && y > posicao.Y && x > posicao.X)
            {
                this.clicado = !this.clicado;
            }

            else
                ok = false;

            return ok;
        }
    }
}
