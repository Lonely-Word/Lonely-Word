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
    public partial class FormPalavra : Form
    {        
        public FormPalavra()
        {
            InitializeComponent();
        }

        public string getPalavra()
        {
            return textBox1.Text;
        }
    }
}
