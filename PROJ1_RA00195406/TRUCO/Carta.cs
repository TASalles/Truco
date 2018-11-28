using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRUCO
{
    class Carta
    {
        #region ATRIBUTOS
        private Texture2D textura;
        private int valor;
        private int linha;
        private int coluna;
        private bool coberta;
        #endregion

        #region PROPRIEDADES
        public Texture2D Textura
        {
            get { return textura; }
        }

        public int Linha
        {
            get { return linha; }
            set { linha = value; }
        }

        public int Coluna
        {
            get { return coluna; }
            set { coluna = value; }
        }

        public bool Coberta
        {
            get { return coberta; }
            set { coberta = value; }
        }
        #endregion


        public Carta(Texture2D tex, int val, int np)
        {
            this.coberta = true;
            this.linha = 0;
            this.coluna = 0;
            this.textura = tex;
            this.valor = val;

        }

        #region METODOS

        public bool Igual(Carta carta)
        {
            bool ok = false;

            if (this.valor == carta.valor) ok = true;

            return ok;
        }
        #endregion
    }

}