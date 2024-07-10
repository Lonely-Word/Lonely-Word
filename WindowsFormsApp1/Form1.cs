using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        //besteiras para o código
        decimal checkk = 0;
        decimal check = 0;
       
        

        public Form1()
        {
            InitializeComponent();
            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            #region clique para jogar
            if (check == 0 || check == 4) //preto p/ cinza escuro
            {
                check = 1;
                timer1.Interval = 300;
                label2.ForeColor = Color.DarkGray;
                
            }
            else if (check == 1) //cinza escuro p/ cinza
            {
                check = 2;
                timer1.Interval = 300;
                label2.ForeColor = Color.Gray;
                
            }
            else if (check == 2) //cinza p/ preto
            {
                check = 3;
                timer1.Interval = 300;
                label2.ForeColor = Color.Black;   
            }
            else if (check == 3) //preto p/ cinza escuro
            {
                check = 4;
                timer1.Interval = 300;
                label2.ForeColor = Color.Gray;
            }


            #endregion

            #region notas
            /*
            Apenas um efeitozinho besta para deixar a tela inicial mais bonita.
            ok, que isso poderia ter sido 1000 vezes mais fácil se eu tivesse
            apenas importado um gif, mas... bem, agora que está feito, está feito, né?
            
            De qualquer forma, já que está meio fraquinho, talvez seja realmente uma
            boa ideia colocar um gif e pronto.
            */
            #endregion
        }

        private void black(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            #region Nome do jogo
            if (checkk == 0) //ponto mais alto (1/3)
            {
                checkk = 1;
                timer2.Interval = 500;
                label1.Location = new Point(24, 57);
            }
            else if (checkk == 1) //ponto médio (2/3)
            {
                checkk = 2;
                timer2.Interval = 500;
                label1.Location = new Point(24, 63);
            }
            else if (checkk == 2) //ponto baixo (3/3)
            {
                checkk = 3;
                timer2.Interval = 500;
                label1.Location = new Point(24, 69);
            }
            else if (checkk == 3) //ponto médio de transição para o mais alto (2/3)
            {
                checkk = 0;
                timer2.Interval = 500;
                label1.Location = new Point(24, 63);
                //depois daqui, a logo retorna para o ponto mais alto, ou seja, checkk reinicia.
                //É um loop infinito
            }
            #endregion

            #region Notas 2
            /*
            Assim como dito na primeira nota, dava para facilitar tudo apenas pondo um gif,
            ao invés de todo um código para descer e subir o nome do jogo
            */
            #endregion
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(); //muda para a página de diálogos
            form2.Show();
            this.Hide();
        }
    }
}
