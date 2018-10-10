﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vendas
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;
        }

        private void trmTempo_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
            {
                this.Opacity += 0.1;
           
            }
            else
            {
                trmTempo.Enabled = false;
                this.Hide();
                frmLogin objTela = new frmLogin();
                objTela.ShowDialog();
            }
        }
    }
}
