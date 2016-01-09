using controlColegio.BL;
using controlColegio.BL.General;
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
        UsuariosBL usuarios { get; set; }
        public frmPrueba()
        {
            InitializeComponent();
            tipos = new GenTiposBL();
            usuarios = new UsuariosBL();
        }

        private void frmPrueba_Load(object sender, EventArgs e)
        {
            tipos.InicializarBD();            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tipos.Agregar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            usuarios.Agregar();
            MessageBox.Show("Usuario registrados satisfactoriamente");
        }
    }
}
