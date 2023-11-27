using SistemaAcademico.Entidades;
using SistemaAcademico.Servicios;
using SistemaAcademico.Servicios.Interfaz;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAcademico
{
    public partial class InscripcionEstudiante : Form
    {
        IServicio servicio = null; 
        Estudiantes nuevo= null;
        public InscripcionEstudiante(FabricaServicio fabrica)
        {
            InitializeComponent();
            servicio = fabrica.CrearServicio();
            servicio = new Servicios.Implementacion.Servicio();
            nuevo = new Estudiantes();
        }

        private void InscripcionEstudiante_Load(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            dtpNac.Value = DateTime.Today;
            txtDni.Text = "";
            txtDireccion.Text = "";
            txtEmail.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ValidarDatos();
            foreach (DataGridViewRow row in dgvEstudiante.Rows)
            {
                if (row.Cells["ColDni"].Value.ToString().Equals(txtDni.Text))
                {
                    MessageBox.Show("Este estudiante ya está cargado...", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            string nom = txtNombre.Text;
            string ape=txtApellido.Text;
            DateTime nac=Convert.ToDateTime(dtpNac.Value);
            string dni=Convert.ToInt32(txtDni.Text).ToString();
            string direc = txtDireccion.Text;
            string email=txtEmail.Text;
            
            dgvEstudiante.Rows.Add(new object[] { nom, ape, nac, dni, "Quitar" });
        }

        private bool ValidarDatos()
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Debe ingresar un nombre");
                txtNombre.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtApellido.Text))
            {
                MessageBox.Show("Debe ingresar un apellido");
                txtApellido.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtDni.Text))
            {
                MessageBox.Show("Debe ingresar un dni");
                txtDni.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Debe ingresar un email");
                txtEmail.Focus();
                return false;
            }
            return true;
        }

        private void dgvEstudiante_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEstudiante.CurrentCell.ColumnIndex == 4)
            {
                dgvEstudiante.Rows.RemoveAt(dgvEstudiante.CurrentRow.Index);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvEstudiante.Rows.Count == 0)
            {
                MessageBox.Show("Debe ingresar al menos un estudiante", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            GrabarEstudiante();
        }

        private void GrabarEstudiante()
        {
            nuevo.Nombre = txtNombre.Text;
            nuevo.Apellido = txtApellido.Text;
            nuevo.Fecha_Nac = dtpNac.Value;
            nuevo.Dni = Convert.ToInt32(txtDni.Text);
            nuevo.Direccion = txtDireccion.Text;
            nuevo.Email= txtEmail.Text;
            if (servicio.CrearEstudiante(nuevo))
            {
                MessageBox.Show("Se registró con éxito el estudiante", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("NO se pudo registrar el estudiante", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea cancelar", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }
    }
}
