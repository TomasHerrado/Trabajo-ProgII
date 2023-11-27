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

namespace SistemaAcademico.Presentacion
{
    public partial class InstripcionMateria : Form
    {
        IServicio servicio = null;
        Catedra nueva= null;
        public InstripcionMateria(FabricaServicio fabrica)
        {
            InitializeComponent();
            servicio = fabrica.CrearServicio();
            servicio = new Servicios.Implementacion.Servicio();
            nueva= new Catedra();
        }

        private void InstripcionMateria_Load(object sender, EventArgs e)
        {
            dtpFechaInscripcion.Value = DateTime.Today;
            CargarCatedras();
            cargarEstudiantes();
            CargarEstado();
            CargarHorario();
            CargarMateria();
            CargarDocente();
            CargarComision();
            cboCatedra.SelectedIndex = -1;
            cboEstadoMateria.SelectedIndex = -1;
            cboEstudiantes.SelectedIndex = -1;
            cboHorario.SelectedIndex = -1;
            cboMateria.SelectedIndex = -1;
            cboDocente.SelectedIndex = -1;
            cboComision.SelectedIndex = -1;
        }

        private void CargarComision()
        {
            cboComision.DataSource = servicio.TraerComision();
            cboComision.ValueMember = "idComision";
            cboComision.DisplayMember = "descripcionComision";
        }

        private void CargarDocente()
        {
            cboDocente.DataSource = servicio.TraerDocentes();
            cboDocente.ValueMember = "id_docente";
            cboDocente.DisplayMember = "nombre";
        }

        private void CargarMateria()
        {
            cboMateria.DataSource = servicio.TraerMaterias();
            cboMateria.ValueMember = "idMateria";
            cboMateria.DisplayMember = "nombreMateria";
        }

        private void CargarHorario()
        {
            cboHorario.DataSource = servicio.TraerHorarios();
            cboHorario.ValueMember = "idHorarios";
            cboHorario.DisplayMember = "diaSemana";
        }

        private void CargarEstado()
        {
            cboEstadoMateria.DataSource = servicio.TraerEstado();
            cboEstadoMateria.ValueMember = "id_estado_materia";
            cboEstadoMateria.DisplayMember = "descripcion";
        }

        private void cargarEstudiantes()
        {
            cboEstudiantes.DataSource = servicio.TraerEstudiante();
            cboEstudiantes.ValueMember = "id_estudiante";
            cboEstudiantes.DisplayMember = "nombre";
        }

        private void CargarCatedras()
        {
            cboCatedra.DataSource = servicio.TraerCatedras();
            cboCatedra.ValueMember = "id_catedra";
            cboCatedra.DisplayMember = "descripcion";
        }

        private void cboEstadoMateria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ValidarDatos();
            foreach (DataGridViewRow row in dgvInscripcion.Rows)
            {
                if (row.Cells["ColCatedra"].Value.Equals(cboCatedra.Text))
                {
                    MessageBox.Show("Esta catedra ya esta agregada"
                   , "Control"
                   , MessageBoxButtons.OK
                   , MessageBoxIcon.Exclamation);
                    return;
                }
                if (row.Cells["ColEstudiante"].Value.Equals(cboEstudiantes.Text))
                {
                    MessageBox.Show("Este estudiante ya esta puesto", "Control"
                        , MessageBoxButtons.OK
                        , MessageBoxIcon.Exclamation);
                    return;
                }//ver
                if (row.Cells["ColEstado"].Value.Equals(cboEstadoMateria.Text))
                {
                    MessageBox.Show("El estado de materia ya esta puesto", "Control"
                        , MessageBoxButtons.OK
                        , MessageBoxIcon.Exclamation);
                    return;
                }

            }
            Estudiantes estudiante = (Estudiantes)cboEstudiantes.SelectedItem;

            Materias m=(Materias)cboMateria.SelectedItem;
            DateTime fecha = Convert.ToDateTime(dtpFechaInscripcion.Value);
            EstadoMateria estado = (EstadoMateria)cboEstadoMateria.SelectedItem;
            Catedra catedra=(Catedra)cboCatedra.SelectedItem;
            InscripcionMateria detalle = new InscripcionMateria(estudiante, fecha, estado,catedra);

            nueva.AgregarDetalle(detalle);
            dgvInscripcion.Rows.Add(new object[] { estudiante.Nombre, catedra.Descripcion, m.NombreMateria, "Quitar" });
        }

        private bool ValidarDatos()
        {
            if (cboCatedra.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una catedra", "Control"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Exclamation);
                return false;
            }
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
            return true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvInscripcion.Rows.Count == 0)
            {
                MessageBox.Show("Debe ingresar al menos una inscripcion", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            GrabarCatedra();
        }

        private void GrabarCatedra()
        {
            nueva.Descripcion=cboCatedra.Text;
            nueva.Horario=cboHorario.SelectedItem as Horarios;
            nueva.Materia = cboMateria.SelectedItem as Materias;
            nueva.Docente = cboDocente.SelectedItem as Docentes;
            nueva.Comision = cboComision.SelectedItem as Comisiones;
            nueva.Año=txtAño.Text;
            nueva.Cuatrimestre=txtCuatrimestre.Text;
            if (servicio.CrearCatedra(nueva))
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

        private void dgvInscripcion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvInscripcion.CurrentCell.ColumnIndex == 3)
            {
                nueva.QuitarDetalle(dgvInscripcion.CurrentRow.Index);
                dgvInscripcion.Rows.RemoveAt(dgvInscripcion.CurrentRow.Index);
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
