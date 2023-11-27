using SistemaAcademicoBackend.Servicios.Interfaz;
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
using SistemaAcademicoBackend.Servicios.Implementacion;
using Newtonsoft.Json;
using SistemaAcademicoBackend.Entidades;
using SistemaAcademicoFrontend.Servicios;
using SistemaAcademicoBackend.Datos;

namespace SistemaAcademicoFrontend.Presentacion
{
    public partial class ConsultarEstudiante : Form
    {
        IServicio servicio;
        FabricaServicio fabrica;
        public ConsultarEstudiante(FabricaServicio fabrica)
        {
            InitializeComponent();
            this.fabrica = fabrica;
            servicio = fabrica.CrearServicio();
            servicio = new Servicio();
        }

        private async void ConsultarEstudiante_Load(object sender, EventArgs e)
        {
            await CargarDni();
            cboDni.SelectedIndex= -1;
        }

        private async Task CargarDni()
        {
            string url = "https://localhost:7111/Estudiante";
            var data = await ClienteSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Estudiantes>>(data);
            cboDni.DataSource = lst;
            cboDni.ValueMember = "id_estudiante";
            cboDni.DisplayMember = "dni";
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string sp = "SP_CONSULTAR_ESTUDIANTES_FILTRO";
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@dni", cboDni.Text));

            dgvEstudiante.Rows.Clear();
            DataTable tabla = new HelperDao().ObtenerInstancia().ConsultaSQL(sp, lst);
            foreach (DataRow fila in tabla.Rows)
            {
                dgvEstudiante.Rows.Add(new object[] {
                    fila["id_estudiante"].ToString(),
                    fila["nombre_estudiante"].ToString(),
                    fila["apellido_estudiante"].ToString(),
                    fila["fecha_nac"].ToString(),
                    fila["direccion"].ToString(),
                    fila["email"].ToString()});
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int nro = int.Parse(dgvEstudiante.CurrentRow.Cells["ColNroEstudiante"].Value.ToString());
            new ModificarEstudiante(fabrica, nro).ShowDialog();
        }

        private async void btnBorrar_Click(object sender, EventArgs e)
        {
            int nroE = int.Parse(dgvEstudiante.CurrentRow.Cells["ColNroEstudiante"].Value.ToString());
            await EliminarEstudiante(nroE);
        }

        private async Task EliminarEstudiante(int nroE)
        {
            if (MessageBox.Show("Seguro que desea quitar al estudiante seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dgvEstudiante.CurrentRow != null)
                {
                    string url = "https://localhost:7111/EliminarEstudiante?id=" + nroE;
                    var result = await ClienteSingleton.GetInstance().DeleteAsync(url);

                    if (result.Equals("true"))
                    {
                        MessageBox.Show("El estudiante se quitó exitosamente!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Dispose();
                    }
                    else
                    {
                        MessageBox.Show("El estudiante NO se quitó exitosamente!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }
    }
}
