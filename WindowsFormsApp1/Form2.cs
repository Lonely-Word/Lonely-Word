using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        
        decimal check2 = 0; //detalhes para passar a imagem
        public Form2()
        {
            InitializeComponent();
         
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            #region notas
            /*
            eu planejava colocar para aparecer letra por letra, ou ao menos
            colocar de uma forma mais bonitinha, entretanto... tá complicado.
            
            Aparentemente envolve muito mais coisa do que eu esperava.
            Se tiver alguma forma de colocar o texto para aparecer de maneira mais
            bonita seria, definitivamente, incrível.
            */
            #endregion

            #region método para passar as imagens/forms
            check2++;
           if (check2 == 1) 
            {
                //muda o texto
                label1.Text = "Novo texto...blablablablablablabla... é só um novo texto, nada demais :P";
                pictureBox1.Image = Properties.Resources._2; //troca para a segunda imagem
            }
            else if (check2 == 2)
            {
                Form3 form3 = new Form3(); //abre novo forms... Nenhum segredo, apenas mais do mesmo.
                form3.Show();
                this.Hide();
            }
            #endregion
        }
    }
}
