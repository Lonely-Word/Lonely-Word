using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LonelyWord
{
    internal class Palavra
    {
        public string palavra;
        public string dica;
        public string direcao;
        public int colIni;
        public int colFim;
        public int rowIni;
        public int rowFim;
        public Palavra(string palavra, string dica, string direcao, int colIni, int colFim, int rowIni, int rowFim)
        {
            this.palavra = palavra;
            this.dica= dica;
            this.direcao = direcao;
            this.colIni = colIni;
            this.colFim = colFim;
            this.rowIni = rowIni;
            this.rowFim = rowFim;
        }
    }
}
