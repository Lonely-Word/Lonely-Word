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
    public partial class FormGameOver : Form
    {
        public FormGameOver()
        {
            InitializeComponent();
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            FormApresentacao fApresentacao = new FormApresentacao(@"..\..\Resources\cutscene01.mp4", 1);
            fApresentacao.Show();
            this.Hide();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            FormMenu fMenu = new FormMenu();
            fMenu.Show();
            this.Hide();
        }
    }
}
