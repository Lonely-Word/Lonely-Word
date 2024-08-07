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
    public partial class FormTutorial : Form
    {
        int passar;

        public FormTutorial()
        {
            passar = 0;
            InitializeComponent();
            btnVoltar.Visible = false;
        }

        private void FormTutorial_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormMenu fMenu = new FormMenu();
            fMenu.Show();
            this.Hide();
        }

        private void FormTutorial_Click(object sender, EventArgs e)
        {
            passar++;

            switch (passar)
            {
                case 1:
                    this.BackgroundImage = Properties.Resources.tutorial02;
                    break;
                case 2:
                    this.BackgroundImage = Properties.Resources.tutorial03;
                    break;
                case 3:
                    this.BackgroundImage = Properties.Resources.tutorial05;
                    break;
                case 4:
                    this.BackgroundImage = Properties.Resources.tutorial04;
                    break;
                case 5:
                    this.BackgroundImage = Properties.Resources.tutorial06;
                    break;
                default:
                    btnVoltar.Visible = true;
                    break;
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FormMenu fMenu = new FormMenu();
            fMenu.Show();
            this.Hide();
        }
    }
}
