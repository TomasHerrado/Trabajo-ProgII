using Newtonsoft.Json;
using SistemaAcademicoBackend.Datos;
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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAcademicoFrontend.Presentacion
{
    public partial class ConsultarMateria : Form
    {
        IServicio servicio;
        FabricaServicio fabrica;
        public ConsultarMateria(FabricaServicio fabrica)
        {
            InitializeComponent();
            this.fabrica = fabrica;
            servicio = fabrica.CrearServicio();
            servicio = new Servicio();
        }

        private async void ConsultarMateria_Load(object sender, EventArgs e)
        {
            await CargarMateria();
            cboMaterias.SelectedIndex = -1;
            dtpDesde.Value=DateTime.Now.AddDays(-7);
            dtpHasta.Value=DateTime.Now;
        }

        private async Task CargarMateria()
        {
            string url = "https://localhost:7111/Materias";
            var data = await ClienteSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Materias>>(data);
            cboMaterias.DataSource = lst;
            cboMaterias.ValueMember = "idMateria";
            cboMaterias.DisplayMember = "nombreMateria";
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string sp = "SP_CONSULTAR_INSCRIPCION";
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@fecha_desde", dtpDesde.Value));
            lst.Add(new Parametro("@fecha_hasta", dtpHasta.Value));
            lst.Add(new Parametro("@materia", cboMaterias.Text));

            dgvConsultarMateria.Rows.Clear();
            DataTable tabla = new HelperDao().ObtenerInstancia().ConsultaSQL(sp, lst);
            foreach (DataRow fila in tabla.Rows)
            {
                dgvConsultarMateria.Rows.Add(new object[] {
                    fila["id_catedra"].ToString(),
                    fila["nombre_estudiante"].ToString(),
                    fila["fecha"].ToString(),
                    fila["nombre_estado_materia"].ToString(),
                    fila["nombre_catedra"].ToString(),
                    "Ver Detalle"});
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            int nro = int.Parse(dgvConsultarMateria.CurrentRow.Cells["ColNroCatedra"].Value.ToString());
            new ModificarInscripcion(fabrica, nro).ShowDialog();
            //this.btnConsultar_Click(null, null);
        }

        private async void btnBorrar_Click(object sender, EventArgs e)
        {
            int nroC = int.Parse(dgvConsultarMateria.CurrentRow.Cells["ColNroCatedra"].Value.ToString());
            await EliminarInscripcion(nroC);
            
        }

        private async Task EliminarInscripcion(object id)
        {
            if (MessageBox.Show("Seguro que desea quitar la inscripcion seleccionada?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dgvConsultarMateria.CurrentRow != null)
                {
                    string url = "https://localhost:7111/EliminarCatedra?id=" + id;
                    var result = await ClienteSingleton.GetInstance().DeleteAsync(url);

                    if (result.Equals("true"))
                    {
                        MessageBox.Show("La inscripcion se quitó exitosamente!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Dispose();
                    }
                    else
                    {
                        MessageBox.Show("La inscripcion NO se quitó exitosamente!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void dgvConsultarMateria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvConsultarMateria.CurrentCell.ColumnIndex == 5)
            {
                int nro = int.Parse(dgvConsultarMateria.CurrentRow.Cells["ColNroCatedra"].Value.ToString());
                new FormVerDetalle(nro).ShowDialog();
            }
        }
    }
}
