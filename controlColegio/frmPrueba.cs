﻿using controlColegio.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace controlColegio
{
    public partial class frmPrueba : Form
    {
        GenTiposBL tipos { get; set; }
        public frmPrueba()
        {
            InitializeComponent();
            tipos = new GenTiposBL();
        }

        private void frmPrueba_Load(object sender, EventArgs e)
        {
            tipos.InicializarBD();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tipos.Agregar();
        }
    }
}
