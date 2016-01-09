using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controlColegio.General
{
    public partial class InicioSesionFrm : Form
    {
        public InicioSesionFrm()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            //var db = dbz.AbrirConexion();
            //var usuarios = new List<Usuarios>();

            //using (MD5 md5Hash = MD5.Create())
            //{
            //    hash = GetMd5Hash(md5Hash, txtContrasenia.Text);
            //}

            //usuarios = db.usuarios.All().Where(db.usuarios.nombre == txtUsuario.Text && db.usuarios.contrasena == hash);

            //if (usuarios.Count > 0)
            //    this.Close();
            //else
            //{
            //    MessageBox.Show("Nombre de usuario o contraseña incorrectos", "Notificación del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txtUsuario.Focus();
            //}
        }
    }
}
