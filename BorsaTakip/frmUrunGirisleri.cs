﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BorsaTakip
{
    public partial class frmUrunGirisleri : Form
    {
        public frmUrunGirisleri()
        {
            InitializeComponent();
        }

        private void frmUrunGirişleri_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
                this.Close();
        }

        private void frmUrunGirişleri_Load(object sender, EventArgs e)
        {

        }
    }
}
