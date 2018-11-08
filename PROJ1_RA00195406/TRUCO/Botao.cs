using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRUCO
{
    class Botao
    {
        #region ATRIBUTOS
        private bool clicado;
        private string legenda;
        private Vector2 posicao;
        #endregion

        public Botao(string leg, Vector2 pos)
        {
            this.clicado = false;
            this.legenda = leg;
            this.posicao = pos;
        }
        #region PROPRIEDADES
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
        public bool VerificaClique(int x, int y)
        {
            bool ok = false;
            if (y < (posicao.Y + 50) && x < posicao.X + 300)
            {
                this.clicado = !this.clicado;
                ok = true;
            }
            return ok;
        }
        #endregion
    }
}
