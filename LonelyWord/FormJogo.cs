using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace LonelyWord
{ 
    public partial class FormJogo : Form
    {
        int fase;  

        private void letraClick(object sender, EventArgs e)
        {
            var letra = (Label)sender;
            var palavra = (Palavra)letra.Tag;
            if (palavra != null)
            {
                FormPalavra pDialog = new FormPalavra();
                if (pDialog.ShowDialog(this) == DialogResult.OK)
                { 
                    if (palavra.palavra == pDialog.getPalavra())
                    {
                        MessageBox.Show("Você acertou!");
                    }                
                }
                pDialog.Dispose();
            }
        }

        private void InitGame()
        {
            List<Palavra> PalavrasFase = new List<Palavra>();
            Fase fase = new Fase();
            switch (this.fase)
            {
                case 1:
                    /* Fase 1 */
                    PalavrasFase.Add(new Palavra("PSICOLOGICO", "Pertencente à psique ou aos fenômenos mentais ou emocionais.", "Vertical", 11, 11, 4, 14));
                    PalavrasFase.Add(new Palavra("SOLIDAO", "Estado de quem se acha ou se sente desacompanhado.", "Vertical", 13, 13, 7, 13));
                    PalavrasFase.Add(new Palavra("ABANDONO", "Ato ou efeito de largar, de sair sem a intenção de voltar.", "Horizontal", 6, 13, 8, 8));
                    PalavrasFase.Add(new Palavra("MELANCOLIA", "Estado de grande tristeza e desencanto gera.", "Horizontal", 5, 14, 10, 10));
                    PalavrasFase.Add(new Palavra("IDOSO", "Que ou quem tem muitos anos de vida.", "Horizontal", 7, 11, 14, 14));
                    fase = new Fase(1, "Consequencias do ABANDONO: solidão, doenças, sindromes.", "Consequencias do ABANDONO: solidão, doenças, sindromes.", PalavrasFase);
                    break;
                case 2:
                    /* Fase 2 */                    
                    PalavrasFase.Add(new Palavra("FILHOS", "", "Horizontal", 5, 10, 15, 15));
                    PalavrasFase.Add(new Palavra("ESPOSA", "", "Vertical", 10, 10, 11, 16));
                    PalavrasFase.Add(new Palavra("NETOS", "", "Horizontal", 9, 13, 11, 11));
                    PalavrasFase.Add(new Palavra("FAMILIA", "", "Horizontal", 8, 14, 6, 6));
                    PalavrasFase.Add(new Palavra("CUIDADOS", "", "Vertical", 13, 13, 4, 11));
                    fase = new Fase(2, "Estrutura familiar, direitos e deveres, filhos, netos, cuidados.", "Estrutura familiar, direitos e deveres, filhos, netos, cuidados.", PalavrasFase);                    
                    break;
                case 3:
                    /* Fase 3 */                    
                    PalavrasFase.Add(new Palavra("SAUDE", "", "Horizontal", 8, 12, 18, 18));
                    PalavrasFase.Add(new Palavra("APOSENTADORIA", "", "Vertical", 7, 7, 0, 12));
                    PalavrasFase.Add(new Palavra("REMEDIOS", "", "Vertical", 14, 14, 8, 15));
                    PalavrasFase.Add(new Palavra("PRIORIDADE", "", "Horizontal", 5, 14, 11, 11));
                    PalavrasFase.Add(new Palavra("GRATUIDADE", "", "Vertical", 12, 12, 9, 18));
                    fase = new Fase(3, "Direitos a transporte público, saúde, vagas preferenciais remédios fisioterapias.", "Direitos a transporte público, saúde, vagas preferenciais remédios fisioterapias.", PalavrasFase);
                    break;
                case 4:
                    /* Fase 4 */                     
                    PalavrasFase.Add(new Palavra("MULTIRAO", "", "Horizontal", 5, 12, 13, 13));
                    PalavrasFase.Add(new Palavra("AMIZADE", "", "Horizontal", 5, 11, 4, 4));
                    PalavrasFase.Add(new Palavra("SUPERACAO", "", "Vertical", 11, 11, 8, 16));
                    PalavrasFase.Add(new Palavra("ASSISTENCIA", "", "Vertical", 9, 9, 4, 14));
                    PalavrasFase.Add(new Palavra("AJUDA", "", "Vertical", 6, 6, 11, 15));
                    fase = new Fase(4, "Velhice não é apenas solidão outros prazeres surgem além das limitações físicas da idade e saúde: respeito, amizade, superação.", "Velhice não é apenas solidão outros prazeres surgem além das limitações físicas da idade e saúde: respeito, amizade, superação.", PalavrasFase);                    
                    break;
                case 5:
                    /* Fase 5 */
                    PalavrasFase.Add(new Palavra("IDOSO", "Que ou quem tem muitos anos de vida.", "Horizontal", 9, 13, 8, 8));
                    PalavrasFase.Add(new Palavra("FAMILIA", "", "Vertical", 14, 14, 10, 16));
                    PalavrasFase.Add(new Palavra("SUPERACAO", "", "Horizontal", 7, 15, 11, 11));
                    PalavrasFase.Add(new Palavra("CUIDADO", "", "Horizontal", 4, 10, 5, 5));
                    PalavrasFase.Add(new Palavra("PRIORIDADE", "", "Vertical", 10, 10, 2, 11));
                    fase = new Fase(5, "Valorize seu idoso, amanhã você será o idoso.", "Valorize seu idoso, amanhã você será o idoso.", PalavrasFase);
                    break;                                                        
            }

            acertos.Text = "Acertos: 0 de 5";
            capitulo.Text = "Capítulo " + this.fase.ToString();
            tema.Text = fase.tema;

            int numLetras = 0;
            int numPalavra = 0;
            Label[] letras = new Label[400];
            foreach (var palavra in PalavrasFase)
            {
                numPalavra++;
                int posLetra = 0;
                for (int col = palavra.colIni; col <= palavra.colFim; col++)
                {
                    for (int row = palavra.rowIni; row <= palavra.rowFim; row++)
                    {                        
                        letras[numLetras] = new Label();
                        if (posLetra == 0)
                        {
                            letras[numLetras].Text = numPalavra.ToString();
                            listBox1.Items.Add(numPalavra.ToString() + ": " + palavra.dica);
                        }
                        //if (palavra.palavra.Count() > posLetra)
                        //letras[numLetras].Text = palavra.palavra.Substring(posLetra, 1);
                        posLetra++;
                        letras[numLetras].BackColor = Color.Gray;
                        letras[numLetras].TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        letras[numLetras].ForeColor = Color.WhiteSmoke;
                        letras[numLetras].Dock= DockStyle.Fill;
                        letras[numLetras].FlatStyle = FlatStyle.Flat;
                        letras[numLetras].Margin = new System.Windows.Forms.Padding(0);
                        letras[numLetras].Tag = palavra;
                        letras[numLetras].Click += new EventHandler(letraClick);
                        var ctrl = palavrasCruzadas.GetControlFromPosition(col, row);
                        if (ctrl == null)                        
                            palavrasCruzadas.Controls.Add(letras[numLetras], col, row);
                        else
                            ctrl.Tag = null;
                        numLetras++;
                    }
                }                              
            }
        }

        public FormJogo(int fase)
        {
            this.fase = fase;
            InitializeComponent();
            InitGame();
        }

        private void FormJogo_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormMenu fMenu = new FormMenu();
            fMenu.Show();
            this.Hide();
        }
    }
}
