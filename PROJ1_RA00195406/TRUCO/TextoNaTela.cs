using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRUCO
{
    class TextoNaTela
    {
        private string titulo1;
        private string titulo2;
        private string texto1;
        private string texto2;

        public TextoNaTela(string titulo1, string titulo2, string texto1, string texto2)
        {
            this.titulo1 = titulo1;
            this.titulo2 = titulo2;
            this.texto1 = texto1;
            this.texto2 = texto2;
        }

        public string Titulo1 { get => titulo1; }
        public string Titulo2 { get => titulo2; }
        public string Texto1 { get => texto1; }
        public string Texto2 { get => texto2; }
    }
}
