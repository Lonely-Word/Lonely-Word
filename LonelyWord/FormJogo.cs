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
            Fase fase;
            switch (this.fase)
            {
                case 1:
                    /* Fase 1 */
                    PalavrasFase.Add(new Palavra("PSICOLOGICO", "", "Vertical", 11, 11, 4, 14));
                    PalavrasFase.Add(new Palavra("SOLIDAO", "", "Vertical", 13, 13, 7, 13));
                    PalavrasFase.Add(new Palavra("ABANDONO", "", "Horizontal", 6, 13, 8, 8));
                    PalavrasFase.Add(new Palavra("MELANCOLIA", "", "Horizontal", 5, 14, 10, 10));
                    PalavrasFase.Add(new Palavra("IDOSO", "", "Horizontal", 7, 11, 14, 14));
                    fase = new Fase(1, "Consequencias do ABANDONO: solidão, doenças, sindromes.", "Consequencias do ABANDONO: solidão, doenças, sindromes.", PalavrasFase);
                    break;
                case 2:
                    /* Fase 2 */
                    /*
                    PalavrasFase.Add(new Palavra("FILHOS", "", "Horizontal", 5, 11, 14, 14));
                    PalavrasFase.Add(new Palavra("ESPOSA", "", "Vertical", 0, 0, 0, 0));
                    PalavrasFase.Add(new Palavra("NETOS", "", "Horizontal", 9, 14, 10, 10));
                    PalavrasFase.Add(new Palavra("FAMILIA", "", "Horizontal", 8, 15, 5, 5));
                    PalavrasFase.Add(new Palavra("CUIDADOS", "", "Vertical", 0, 0, 0, 0));
                    fase = new Fase(2, "Estrutura familiar, direitos e deveres, filhos, netos, cuidados.", "Estrutura familiar, direitos e deveres, filhos, netos, cuidados.", PalavrasFase);
                    */
                    break;
                case 3:
                    /* Fase 3 */
                    /*
                    PalavrasFase.Add(new Palavra("SAÚDE", "", "Vertical", 0, 0, 0, 0));
                    PalavrasFase.Add(new Palavra("APOSENTADORIA", "", "Vertical", 0, 0, 0, 0));
                    PalavrasFase.Add(new Palavra("REMÉDIOS", "", "Vertical", 0, 0, 0, 0));
                    PalavrasFase.Add(new Palavra("VAGA PREFERENCIAL", "", "Vertical", 0, 0, 0, 0));
                    PalavrasFase.Add(new Palavra("ASSENTO PREFERENCIAL", "", "Vertical", 0, 0, 0, 0));
                    fase = new Fase(3, "Direitos a transporte público, saúde, vagas preferenciais remédios fisioterapias.", "Direitos a transporte público, saúde, vagas preferenciais remédios fisioterapias.", PalavrasFase);
                    */
                    break;
                case 4:
                    /* Fase 4 */ 
                    /*
                    PalavrasFase.Add(new Palavra("MULTIRAO", "", "Vertical", 0, 0, 0, 0));
                    PalavrasFase.Add(new Palavra("AMIZADE", "", "Vertical", 0, 0, 0, 0));
                    PalavrasFase.Add(new Palavra("SUPERACAO", "", "Vertical", 0, 0, 0, 0));
                    PalavrasFase.Add(new Palavra("ASSISTENCIA", "", "Vertical", 0, 0, 0, 0));
                    PalavrasFase.Add(new Palavra("AJUDA", "", "Vertical", 0, 0, 0, 0));
                    fase = new Fase(4, "Velhice não é apenas solidão outros prazeres surgem além das limitações físicas da idade e saúde: respeito, amizade, superação.", "Velhice não é apenas solidão outros prazeres surgem além das limitações físicas da idade e saúde: respeito, amizade, superação.", PalavrasFase);
                    */
                    break;
                case 5:
                    /* Fase 5 */
                    /*
                    PalavrasFase.Add(new Palavra("MULTIRAO", "", "Vertical", 0, 0, 0, 0));
                    PalavrasFase.Add(new Palavra("AMIZADE", "", "Vertical", 0, 0, 0, 0));
                    PalavrasFase.Add(new Palavra("SUPERACAO", "", "Vertical", 0, 0, 0, 0));
                    PalavrasFase.Add(new Palavra("ASSISTENCIA", "", "Vertical", 0, 0, 0, 0));
                    PalavrasFase.Add(new Palavra("AJUDA", "", "Vertical", 0, 0, 0, 0));
                    fase = new Fase(5, "Valorize seu idoso, amanhã você será o idoso.", "Valorize seu idoso, amanhã você será o idoso.", PalavrasFase);
                    */
                    break;                                        
                default:
                    FormMenu fMenu = new FormMenu();
                    fMenu.Show();
                    this.Hide();
                    break;
            }
            
            int numLetras = 0;
            Label[] letras = new Label[400];
            foreach (var palavra in PalavrasFase)
            {
                int posLetra = 0;
                for (int col = palavra.colIni; col <= palavra.colFim; col++)
                {
                    for (int row = palavra.rowIni; row <= palavra.rowFim; row++)
                    {                        
                        letras[numLetras] = new Label();
                        if (palavra.palavra.Count() > posLetra)
                            letras[numLetras].Text = palavra.palavra.Substring(posLetra, 1);
                        posLetra++;
                        letras[numLetras].BackColor = Color.Gray;
                        letras[numLetras].TextAlign = ContentAlignment.MiddleCenter;
                        letras[numLetras].ForeColor = Color.WhiteSmoke;
                        letras[numLetras].Dock= DockStyle.Fill;
                        letras[numLetras].FlatStyle = FlatStyle.Flat;
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
