using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LonelyWord
{
    public partial class FormJogo : Form
    {
        int fase;

        public FormJogo(int fase)
        {
            this.fase = fase;
            InitializeComponent();           
        }

        private void FormJogo_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormMenu fMenu = new FormMenu();
            fMenu.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void vidadois_Click(object sender, EventArgs e)
        {

        }

        private void check_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
