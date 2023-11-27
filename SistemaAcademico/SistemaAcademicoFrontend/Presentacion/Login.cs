using AutoMapper;
using SistemaAcademicoBackend.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAcademicoFrontend.Presentacion
{
    public partial class Login : Form
    {
        FabricaServicio fabrica = null;
        private readonly IMapper _mapper;
        public Login(FabricaServicio fabrica,IMapper mapper)
        {
            InitializeComponent();
            this.fabrica = fabrica;
            _mapper = mapper;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "usuario" && txtContraseña.Text == "contraseña")
            {
                Form1 frmInicio = new Form1(fabrica,_mapper);
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

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
