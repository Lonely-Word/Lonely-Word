using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LonelyWord
{
    internal class Fase
    {
        public int fase;
        public string tema;
        public string resumo;
        public List<Palavra> palavras;

        public Fase(int fase, string tema, string resumo, List<Palavra> palavras)
        {
            this.fase = fase;
            this.tema = tema;
            this.resumo = resumo;
            this.palavras = palavras;
        }
    }
}
