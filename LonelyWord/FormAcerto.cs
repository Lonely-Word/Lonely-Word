﻿using System;
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
    public partial class FormAcerto : Form
    {
        public void SetMsg(string Msg)
        {
            label1.Text = Msg;
        }

        public FormAcerto()
        {
            InitializeComponent();
        }
    }
}
