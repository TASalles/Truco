using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesPrivate
{
    class Carta
    {
        private int rank;
        private Vector2 pos;
        private bool coberta;

        public Carta (Vector2 Posicao, bool Coberta, int Rank )
        {
            this.pos = Posicao;
            this.rank = Rank;
            this.coberta = Coberta;

        }

        public int Rank
        {
            get { return rank; }
        }

        public Vector2 Pos
        {
            get { return pos; }
        }

        public bool Coberta
        {
            get { return coberta; }
        }
    }
}
