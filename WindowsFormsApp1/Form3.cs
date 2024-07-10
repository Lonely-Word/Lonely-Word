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
    public partial class Form3 : Form
    {
        string[] texto = new string[2];
        int check;
        public Form3()
        {
            InitializeComponent();
            texto[0] ="batata";
            texto[1] = "batatinha";
            check = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (check == 2)
            {
                check = 3;
                MessageBox.Show("TERMINOU!!!");
            }

           if (textBox1.Text == texto[0])
            {
                check++;
                texto[0] = "pronto";
                MessageBox.Show("EUREKA");
                
            }
           if (textBox2.Text == texto[1])
            {
                check++;
                texto[1] = "pronto";
                MessageBox.Show("EUREKA DE NOVO!!");
            }
           
        }
    }
}
