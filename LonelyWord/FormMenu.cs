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

namespace LonelyWord
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btnCreditos_Click(object sender, EventArgs e)
        {
            FormCreditos fCreditos = new FormCreditos();
            fCreditos.Show();
            this.Hide();
        }

        private void btnTutorial_Click(object sender, EventArgs e)
        {
            FormTutorial fTutorial = new FormTutorial();
            fTutorial.Show();
            this.Hide();
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            FormApresentacao fApresentacao = new FormApresentacao();
            fApresentacao.Show();
            this.Hide();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
