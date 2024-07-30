using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace WindowsFormsApp1
{
    public partial class FormApresentacao : Form
    {
        public FormApresentacao()
        {
            InitializeComponent();
         
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            

        }

        private void FormApresentacao_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"video.mp4";
            axWindowsMediaPlayer1.uiMode = "None";
        }

        private void FormApresentacao_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormMenu fMenu = new FormMenu();
            fMenu.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormJogo fJogo = new FormJogo();
            fJogo.Show();
            this.Hide();
        }
    }
}
