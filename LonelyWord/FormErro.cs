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
    public partial class FormErro : Form
    {
        public void SetMsgDica(string Msg, string Dica)
        {
            label1.Text = Msg;
            label2.Text = Dica;
        }

        public FormErro()
        {
            InitializeComponent();

            label1.Text = "Ops! :(";
            label2.Text = "";
        }
        public FormErro(string Msg, string Dica = "")
        {
            InitializeComponent();

            label1.Text = Msg;
            label2.Text = Dica;
        }
    }
}
