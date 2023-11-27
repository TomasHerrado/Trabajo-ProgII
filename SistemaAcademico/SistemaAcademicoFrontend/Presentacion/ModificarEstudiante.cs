using Newtonsoft.Json;
using SistemaAcademicoBackend.Datos;
using SistemaAcademicoBackend.Entidades;
using SistemaAcademicoBackend.Servicios;
using SistemaAcademicoBackend.Servicios.Interfaz;
using SistemaAcademicoFrontend.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaAcademicoFrontend.Presentacion
{
    public partial class ModificarEstudiante : Form
    {
        IServicio servicio;
        private Estudiantes oEstudiante;
        public ModificarEstudiante(FabricaServicio fabrica, int nroEstudiante)
        {
            InitializeComponent();
            servicio = fabrica.CrearServicio();
            oEstudiante = new Estudiantes();
            oEstudiante.Id_Estudiante = nroEstudiante;
        }

        private void ModificarEstudiante_Load(object sender, EventArgs e)
        {
            string sp = "SP_CONSULTAR_ESTUDIANTES_MOD";
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@id_estudiante", oEstudiante.Id_Estudiante));
            DataTable tabla = new HelperDao().ObtenerInstancia().ConsultaSQL(sp, lst);
            bool primero = true;
            foreach (DataRow fila in tabla.Rows)
            {
                if (primero)
                {
                    oEstudiante.Nombre = fila["nombre_estudiante"].ToString();
                    txtNombre.Text=oEstudiante.Nombre;
                    oEstudiante.Apellido= fila["apellido_estudiante"].ToString();
                    txtApellido.Text=oEstudiante.Apellido;
                    oEstudiante.Fecha_Nac = Convert.ToDateTime(fila["fecha_nac"].ToString());
                    dtpNac.Value = oEstudiante.Fecha_Nac;
                    oEstudiante.Dni = int.Parse(fila["dni"].ToString());
                    txtDni.Text = oEstudiante.Dni.ToString();
                    oEstudiante.Direccion= fila["direccion"].ToString();
                    txtDireccion.Text = oEstudiante.Direccion;
                    oEstudiante.Telefono = int.Parse(fila["telefono"].ToString());
                    txtTelefono.Text = oEstudiante.Telefono.ToString();
                    oEstudiante.Email= fila["email"].ToString();
                    txtEmail.Text = oEstudiante.Email;
                    oEstudiante.EstadoCivil= fila["estado_civil"].ToString();
                    txtEstado.Text = oEstudiante.EstadoCivil;
                    oEstudiante.SitLaboral= fila["situacion_laboral"].ToString();
                    txtSitLab.Text = oEstudiante.SitLaboral;
                    oEstudiante.SitHabitacional= fila["situacion_habitacional"].ToString();
                    txtSitHab.Text = oEstudiante.SitHabitacional;
                    primero = false;
                }
                
                dgvEstudiante.Rows.Add(new object[]
                {
                    oEstudiante.Nombre,
                    oEstudiante.Apellido,
                    oEstudiante.Fecha_Nac,
                    oEstudiante.Dni,
                    "Quitar"
                });
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
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
            string ape = txtApellido.Text;
            DateTime nac = Convert.ToDateTime(dtpNac.Value);
            string dni = Convert.ToInt32(txtDni.Text).ToString();
            string direc = txtDireccion.Text;
            string email = txtEmail.Text;

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
                MessageBox.Show("Debe ingresar al menos un estudiante"
                    , "Control"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Exclamation);
                return;
            }
            
            await ModificarEstudiantes();
        }

        private async Task ModificarEstudiantes()
        {
            oEstudiante.Nombre = txtNombre.Text;
            oEstudiante.Apellido = txtApellido.Text;
            oEstudiante.Fecha_Nac = Convert.ToDateTime(dtpNac.Value);
            oEstudiante.Dni = Convert.ToInt32(txtDni.Text);
            oEstudiante.Direccion = txtDireccion.Text;
            oEstudiante.Telefono=Convert.ToInt32(txtTelefono.Text);
            oEstudiante.Email = txtEmail.Text;
            oEstudiante.EstadoCivil = txtEstado.Text;
            oEstudiante.SitHabitacional = txtSitHab.Text;
            oEstudiante.SitLaboral = txtSitLab.Text;
            

            string bodyContent = JsonConvert.SerializeObject(oEstudiante);
            string url = "https://localhost:7111/EditarEstudiante?nro="+ oEstudiante.Id_Estudiante;
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
            this.Dispose();
        }
    }
}
