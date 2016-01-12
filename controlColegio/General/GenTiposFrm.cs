using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using controlColegio.DATOS.BL.General;
using controlColegio.MODEL.General;

namespace controlColegio.General
{
    public partial class GenTiposFrm : Form
    {
        private GenTiposBL tipoBL  { get; set; }
        public GenTiposFrm()
        {
            InitializeComponent();
            tipoBL = new GenTiposBL();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            GenTiposModel model = new GenTiposModel();
            model.id = Convert.ToInt32(txtId.Text);
            model.nombre = txtNombre.Text;
            model.sigla = txtSigla.Text;
            model.tipo = txtNuevoTipoDato.Text;
            model.estado = Convert.ToInt32(chbEstado.Checked);
            dynamic res = tipoBL.Agregar(model);
            if (res.resultado)                 
                MessageBox.Show("Tipo de datos registrado satisfactoriamente", "Registro Satisfactorio", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Error al registrar dato","Registro erroneo",MessageBoxButtons.RetryCancel,MessageBoxIcon.Error);
        }

        private void GenTiposFrm_Load(object sender, EventArgs e)
        {
            dgv.DataSource= tipoBL.Obtener();
        }        
    }
}
