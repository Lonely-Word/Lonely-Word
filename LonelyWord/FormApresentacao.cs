using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace LonelyWord
{
    public partial class FormApresentacao : Form
    {

        int fase;
        string video;

        public FormApresentacao(string video, int fase)
        {
            this.video = video;
            this.fase = fase;
            InitializeComponent();
        }
        

        private void FormApresentacao_Load(object sender, EventArgs e)
        {            
            axWindowsMediaPlayer1.URL = Path.GetFullPath(this.video);
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
