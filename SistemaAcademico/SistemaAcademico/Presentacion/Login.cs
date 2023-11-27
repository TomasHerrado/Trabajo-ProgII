using SistemaAcademico.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAcademico.Presentacion
{
    public partial class Login : Form
    {
        FabricaServicio fabrica = null;
        public Login(FabricaServicio fabrica)
        {
            InitializeComponent();
            this.fabrica = fabrica;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "usuario" && txtContraseña.Text == "contraseña")
            {
                Form1 frmInicio = new Form1(fabrica);
                this.Hide();
                frmInicio.Show();
            }
            else
            {
                MessageBox.Show("Los datos ingresados son incorrectos");
                txtUsuario.Clear();
                txtContraseña.Clear();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtUsuario.Clear();
            txtContraseña.Clear();
        }
    }
}
