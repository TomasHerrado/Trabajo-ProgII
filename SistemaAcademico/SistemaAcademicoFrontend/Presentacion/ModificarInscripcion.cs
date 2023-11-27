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

namespace SistemaAcademicoFrontend.Presentacion
{
    public partial class ModificarInscripcion : Form
    {
        IServicio servicio;
        private Catedra oCatedra;
        public ModificarInscripcion(FabricaServicio fabrica,int nroCatedra)
        {
            InitializeComponent();
            servicio = fabrica.CrearServicio();
            oCatedra = new Catedra();
            oCatedra.Id_catedra = nroCatedra;
        }

        private async void ModificarInscripcion_Load(object sender, EventArgs e)
        {
            dtpFechaInscripcion.Value = DateTime.Today;
            await CargarCatedras();
            await CargarEstudiante();
            await CargarEstado();
            await CargarHorario();
            await CargarMateria();
            await CargarDocente();
            await CargarComision();
            cboCatedra.SelectedIndex = -1;
            cboEstadoMateria.SelectedIndex = -1;
            cboEstudiantes.SelectedIndex = -1;
            cboHorarios.SelectedIndex = -1;
            cboMaterias.SelectedIndex = -1;
            cboDocentes.SelectedIndex = -1;
            cboComision.SelectedIndex = -1;

            string sp = "SP_CONSULTAR_DETALLE_INSCRIPCION";
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@id_catedra", oCatedra.Id_catedra));
            DataTable tabla = new HelperDao().ObtenerInstancia().ConsultaSQL(sp, lst);
            bool primero = true;
            foreach (DataRow fila in tabla.Rows)
            {
                if (primero)
                {
                    oCatedra.Descripcion = fila["nombre_catedra"].ToString();
                    cboCatedra.Text = oCatedra.Descripcion;
                    //oCatedra.Horario = cboHorarios.SelectedItem as Horarios;
                    //oCatedra.Materia = cboMaterias.SelectedItem as Materias;
                    //oCatedra.Docente = cboDocentes.SelectedItem as Docentes;
                    //oCatedra.Comision = cboComision.SelectedItem as Comisiones;
                    oCatedra.Año = fila["año"].ToString();
                    txtAño.Text = oCatedra.Año;
                    oCatedra.Cuatrimestre = fila["cuatrimestre"].ToString();
                    txtCuatrimestre.Text = oCatedra.Cuatrimestre;
                    primero = false;
                }
                //Estudiantes estudiante = (Estudiantes)cboEstudiantes.SelectedItem;

                //Materias m = (Materias)cboMaterias.SelectedItem;
                //DateTime fecha = Convert.ToDateTime(dtpFechaInscripcion.Value);
                //EstadoMateria estado = (EstadoMateria)cboEstadoMateria.SelectedItem;
                //Catedra catedra = (Catedra)cboCatedra.SelectedItem;
                //InscripcionMateria detalle = new InscripcionMateria(estudiante, fecha, estado, catedra);

                //oCatedra.AgregarDetalle(detalle);
                //dgvInscripcion.Rows.Add(new object[] { estudiante.Nombre, catedra.Descripcion, m.NombreMateria, "Quitar" });
            }


        }

        private async Task CargarComision()
        {
            string url = "https://localhost:7111/Comision";
            var data = await ClienteSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Comisiones>>(data);
            cboComision.DataSource = lst;
            cboComision.ValueMember = "idComision";
            cboComision.DisplayMember = "descripcionComision";
            cboComision.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private async Task CargarDocente()
        {
            string url = "https://localhost:7111/Docentes";
            var data = await ClienteSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Docentes>>(data);
            cboDocentes.DataSource = lst;
            cboDocentes.ValueMember = "id_docente";
            cboDocentes.DisplayMember = "nombre";
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

        private async Task CargarHorario()
        {
            string url = "https://localhost:7111/Horarios";
            var data = await ClienteSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Horarios>>(data);
            cboHorarios.DataSource = lst;
            cboHorarios.ValueMember = "idHorarios";
            cboHorarios.DisplayMember = "diaSemana";
        }

        private async Task CargarCatedras()
        {
            string url = "https://localhost:7111/Catedras";
            var data = await ClienteSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Catedra>>(data);
            cboCatedra.DataSource = lst;
            cboCatedra.DisplayMember = "descripcion";
            cboCatedra.ValueMember = "id_catedra";

        }
        private async Task CargarEstudiante()
        {
            string url = "https://localhost:7111/Estudiante";
            var data = await ClienteSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Estudiantes>>(data);
            cboEstudiantes.DataSource = lst;
            cboEstudiantes.DisplayMember = "nombre";
            cboEstudiantes.ValueMember = "id_estudiante";

        }
        private async Task CargarEstado()
        {
            string url = "https://localhost:7111/Estado";
            var data = await ClienteSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<EstadoMateria>>(data);
            cboEstadoMateria.DataSource = lst;
            cboEstadoMateria.DisplayMember = "descripcion";
            cboEstadoMateria.ValueMember = "id_estado_materia";
        
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ValidarDatos();
            //foreach (DataGridViewRow row in dgvInscripcion.Rows)
            //{
            //    if (row.Cells["ColCatedra"].Value.Equals(cboCatedra.Text))
            //    {
            //        MessageBox.Show("Esta catedra ya esta agregada"
            //       , "Control"
            //       , MessageBoxButtons.OK
            //       , MessageBoxIcon.Exclamation);
            //        return;
            //    }
            //    if (row.Cells["ColEstudiante"].Value.Equals(cboEstudiantes.Text))
            //    {
            //        MessageBox.Show("Este estudiante ya esta puesto", "Control"
            //            , MessageBoxButtons.OK
            //            , MessageBoxIcon.Exclamation);
            //        return;
            //    }
            //    if (row.Cells["ColEstado"].Value.Equals(cboEstadoMateria.Text))
            //    {
            //        MessageBox.Show("El estado de materia ya esta puesto", "Control"
            //            , MessageBoxButtons.OK
            //            , MessageBoxIcon.Exclamation);
            //        return;
            //    }
            //}
            Estudiantes estudiante = (Estudiantes)cboEstudiantes.SelectedItem;

            Materias m = (Materias)cboMaterias.SelectedItem;
            DateTime fecha = Convert.ToDateTime(dtpFechaInscripcion.Value);
            EstadoMateria estado = (EstadoMateria)cboEstadoMateria.SelectedItem;
            Catedra catedra = (Catedra)cboCatedra.SelectedItem;
            InscripcionMateria detalle = new InscripcionMateria(estudiante, fecha, estado, catedra);

            oCatedra.AgregarDetalle(detalle);
            dgvInscripcion.Rows.Add(new object[] { estudiante.Nombre, catedra.Descripcion, m.NombreMateria, "Quitar" });
        }

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvInscripcion.Rows.Count == 0)
            {
                MessageBox.Show("Debe ingresar al menos una inscripcion"
                    , "Control"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Exclamation);
                return;
            }
            await ModificarCatedra();
        }

        private async Task ModificarCatedra()
        {
            oCatedra.Descripcion = cboCatedra.Text;
            oCatedra.Horario = cboHorarios.SelectedItem as Horarios;
            oCatedra.Materia = cboMaterias.SelectedItem as Materias;
            oCatedra.Docente = cboDocentes.SelectedItem as Docentes;
            oCatedra.Comision = cboComision.SelectedItem as Comisiones;
            oCatedra.Año = txtAño.Text;
            oCatedra.Cuatrimestre = txtCuatrimestre.Text;

            string bodyContent = JsonConvert.SerializeObject(oCatedra);
            string url = "https://localhost:7111/EditarCatedra?nro="+oCatedra.Id_catedra;
            var result = await ClienteSingleton.GetInstance().PostAsync(url, bodyContent);

            if (result.Equals("true"))
            {
                MessageBox.Show("Se registró con éxito la inscripcion", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {

                MessageBox.Show("NO se pudo registrar la inscripcion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private bool ValidarDatos()
        {
            if (cboEstudiantes.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un estudiante", "Control"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Exclamation);
                return false;
            }
            if (cboEstadoMateria.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar el estado de la materia", "Control"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Exclamation);
                return false;
            }
            if (cboCatedra.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una catedra", "Control"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Exclamation);
                return false;
            }
            if (cboHorarios.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un horario", "Control"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Exclamation);
                return false;
            }
            if (cboMaterias.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una materia", "Control"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Exclamation);
                return false;
            }
            if (cboDocentes.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un docente", "Control"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Exclamation);
                return false;
            }
            if (cboComision.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una comision", "Control"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Exclamation);
                return false;
            }
            if (string.IsNullOrEmpty(txtAño.Text))
            {
                MessageBox.Show("Debe ingresar un año", "Control"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Exclamation);
                return false;
            }
            if (string.IsNullOrEmpty(txtCuatrimestre.Text))
            {
                MessageBox.Show("Debe ingresar un cuatrimestre", "Control"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }

        private void dgvInscripcion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvInscripcion.CurrentCell.ColumnIndex == 3)
            {
                oCatedra.QuitarDetalle(dgvInscripcion.CurrentRow.Index);
                dgvInscripcion.Rows.RemoveAt(dgvInscripcion.CurrentRow.Index);
            }
        }
    }
}
