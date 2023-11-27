using Newtonsoft.Json;
using SistemaAcademicoBackend.Entidades;
using SistemaAcademicoBackend.Servicios;
using SistemaAcademicoBackend.Servicios.Implementacion;
using SistemaAcademicoBackend.Servicios.Interfaz;
using SistemaAcademicoFrontend.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAcademicoFrontend.Presentacion
{
    public partial class InscripcionEstudiante : Form
    {
        IServicio servicio; 
        Estudiantes nuevo;
        public InscripcionEstudiante(FabricaServicio fabrica)
        {
            InitializeComponent();
            servicio = fabrica.CrearServicio();
            servicio = new Servicio();
            nuevo = new Estudiantes();
            txtEmail.TextChanged += txtEmail_TextChanged;
            btnAgregar.Enabled = false;
            btnAceptar.Enabled = false;
        }

        private void InscripcionEstudiante_Load(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            dtpNac.Value = DateTime.Today;
            txtDni.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
            txtEstado.Text = "";
            txtSitHab.Text = "";
            txtSitLab.Text = "";
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
            if (!int.TryParse(txtDni.Text, out int dni))
            {
                MessageBox.Show("El DNI debe ser un número válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDni.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtDireccion.Text))
            {
                MessageBox.Show("Debe ingresar una direccion");
                txtDireccion.Focus();
                return false;
            }
            if (!int.TryParse(txtTelefono.Text, out int telefono))
            {
                MessageBox.Show("El telefono debe ser un número válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTelefono.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Debe ingresar un email");
                txtEmail.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtEstado.Text))
            {
                MessageBox.Show("Debe ingresar un estado");
                txtEmail.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtSitHab.Text))
            {
                MessageBox.Show("Debe ingresar una situacion habitacional");
                txtEmail.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtSitLab.Text))
            {
                MessageBox.Show("Debe ingresar una situacion laboral");
                txtEmail.Focus();
                return false;
            }
            return true;
        }
        public static void SoloLetras(KeyPressEventArgs v)
        {
            if (Char.IsLetter(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsSeparator(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsControl(v.KeyChar))
            {
                v.Handled = false;
            }
            else
            {
                v.Handled = true;
                MessageBox.Show("Solo Letras");
            }
        }

        public static void SoloNumeros(KeyPressEventArgs v)
        {
            if (Char.IsDigit(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsSeparator(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsControl(v.KeyChar))
            {
                v.Handled = false;
            }
            else
            {
                v.Handled = true;
                MessageBox.Show("Solo Numeros");
            }
        }

        private void dgvEstudiante_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEstudiante.CurrentCell.ColumnIndex == 4)
            {
                dgvEstudiante.Rows.RemoveAt(dgvEstudiante.CurrentRow.Index);
            }
        }

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvEstudiante.Rows.Count == 0)
            {
                MessageBox.Show("Debe ingresar al menos un estudiante", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            await GrabarEstudiante();
        }

        private async Task GrabarEstudiante()
        {
            nuevo.Nombre = txtNombre.Text;
            nuevo.Apellido = txtApellido.Text;
            nuevo.Fecha_Nac = Convert.ToDateTime(dtpNac.Value);
            nuevo.Dni = Convert.ToInt32(txtDni.Text);
            nuevo.Direccion = txtDireccion.Text;
            nuevo.Telefono= Convert.ToInt32(txtTelefono.Text);
            nuevo.Email= txtEmail.Text;
            nuevo.EstadoCivil= txtEstado.Text;
            nuevo.SitHabitacional = txtSitHab.Text;
            nuevo.SitLaboral=txtSitLab.Text;

            string bodyContent = JsonConvert.SerializeObject(nuevo);
            string url = "https://localhost:7111/InsertarEstudiante";
            var result = await ClienteSingleton.GetInstance().PostAsync(url, bodyContent);

            if (result.Equals("true"))
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

        //private void InitializeComponent()
        //{
        //    this.SuspendLayout();
        //    // 
        //    // InscripcionEstudiante
        //    // 
        //    this.ClientSize = new System.Drawing.Size(278, 244);
        //    this.Name = "InscripcionEstudiante";
        //    this.Load += new System.EventHandler(this.InscripcionEstudiante_Load_1);
        //    this.ResumeLayout(false);

        //}

        private void InscripcionEstudiante_Load_1(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtEstado_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEstado_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
        }

        private void txtSitHab_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
        }

        private void txtSitLab_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            btnAceptar.Enabled = ValidarEmail(txtEmail.Text);
            ///////////
            btnAgregar.Enabled = ValidarEmail(txtEmail.Text);
        }
        private bool ValidarEmail(string email)
        {

            string patron = @"^.+@.+\..+$";
            Regex regex = new Regex(patron);

            return regex.IsMatch(email);
        }
    }
}
