using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRUCO
{
    class Tabuleiro
    {
        #region ATRIBUTOS
        private Carta[,] tab;
        private int linhas;
        private int colunas;
        #endregion

        #region PROPRIEDADES
        public int Linhas
        {
            get { return linhas; }
        }
        public int Colunas
        {
            get { return colunas; }
        }

        public int numeroDePares
        {
            get { return (linhas * colunas / 2); }
        }

        public Carta GetCarta(int lin, int col)
        {
            Carta carta = null;

            if ((lin >= 0 && lin < linhas) &&
                (colunas >= 0 && col < colunas)
                )
            {
                carta = tab[lin, col];
            }
            return carta;
        }
        #endregion

        public Tabuleiro(int numLin, int numCol)
        {
            this.linhas = numLin;
            this.colunas = numCol;
            this.tab = new Carta[numLin, numCol];
        }

        #region MÉTODOS
        public bool Colocar(Carta carta, int lin, int col)
        {
            bool ok = false;

            if ((lin >= 0 && lin < linhas) &&
                (colunas >= 0 && col < colunas)
                )
            {
                if (tab[lin, col] == null)
                {
                    tab[lin, col] = carta;
                    ok = true;
                }
            }

            return ok;
        }
        #endregion
    }
}
