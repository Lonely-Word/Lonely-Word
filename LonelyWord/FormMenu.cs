using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LonelyWord
{
    public partial class FormMenu : Form
    {

        SoundPlayer player;


        public FormMenu()
        {
            InitializeComponent();
        }

        private void btnCreditos_Click(object sender, EventArgs e)
        {
            FormCreditos fCreditos = new FormCreditos();
            fCreditos.Show();
            player.Stop();
            this.Hide();
        }

        private void btnTutorial_Click(object sender, EventArgs e)
        {
            FormTutorial fTutorial = new FormTutorial();
            fTutorial.Show();
            player.Stop();
            this.Hide();
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {   
            FormApresentacao fApresentacao = new FormApresentacao(@"..\..\Resources\cutscene01.mp4", 1);
            fApresentacao.Show();
            player.Stop();
            this.Hide();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FormMenu_Shown(object sender, EventArgs e)
        {
            player = new SoundPlayer(Properties.Resources.menu);
            player.Play();
        }

        private void FormMenu_Leave(object sender, EventArgs e)
        {
            player.Stop();
        }
    }
}
