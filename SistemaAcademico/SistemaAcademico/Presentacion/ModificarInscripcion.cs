using SistemaAcademico.Datos;
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
    public partial class ModificarInscripcion : Form
    {
        IServicio servicio = null;
        private Catedra oCatedra;
        public ModificarInscripcion(FabricaServicio fabrica,int nroCatedra)
        {
            InitializeComponent();
            servicio = fabrica.CrearServicio();
            oCatedra = new Catedra();
            oCatedra.Id_catedra = nroCatedra;
            CargarCatedras();
            CargarEstudiante();
            CargarEstado();
            cboCatedra.SelectedIndex= -1;
            cboEstudiantes.SelectedIndex= -1;
            cboEstadoMateria.SelectedIndex= -1;
        }

        private void ModificarInscripcion_Load(object sender, EventArgs e)
        {
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
                    oCatedra.Horario = (Horarios)fila["dia_semana"];
                    cboHorarios.Text = oCatedra.Horario.ToString();
                    oCatedra.Materia = (Materias)fila["nombre_materia"];
                    cboMaterias.Text = oCatedra.Materia.ToString();
                    oCatedra.Docente = (Docentes)fila["nombre_docente"];
                    cboDocentes.Text = oCatedra.Docente.ToString();
                    oCatedra.Comision = (Comisiones)fila["nombre_comision"];
                    cboComision.Text = oCatedra.Comision.ToString();
                    oCatedra.Año = fila["año"].ToString();
                    txtAño.Text = oCatedra.Año;
                    oCatedra.Cuatrimestre = fila["cuatrimestre"].ToString();
                    txtCuatrimestre.Text = oCatedra.Cuatrimestre;
                    primero = false;
                }

                int codigo = int.Parse(fila["id_estudiante"].ToString());
                string nombre = fila["nombre_estudiante"].ToString();
                string ape = fila["apellido_estudiante"].ToString();
                DateTime fec = Convert.ToDateTime(fila["fecha_nac"]);
                int dni = int.Parse(fila["dni"].ToString());
                string direc = fila["direccion"].ToString();
                int tel = int.Parse(fila["telefono"].ToString());
                string email = fila["email"].ToString();
                string EstCiv = fila["estado_civil"].ToString();
                string SH = fila["situacion_habitacional"].ToString();
                string SL = fila["situacion_laboral"].ToString();
                Estudiantes oEstudiante = new Estudiantes(codigo, nombre, ape, fec, dni, direc, tel, email, EstCiv, SH, SL);

                DateTime fecha = Convert.ToDateTime(fila["fecha"]);
                EstadoMateria estado = (EstadoMateria)fila["nombre_estado_materia"];
                Catedra catedra = (Catedra)fila["nombre_catedra"];
                InscripcionMateria oInscripcion = new InscripcionMateria(oEstudiante,fecha,estado,catedra);

                oCatedra.AgregarDetalle(oInscripcion);
                dgvInscripcion.Rows.Add(new object[]
                {
                    oEstudiante.Nombre,
                    oInscripcion.Catedras.Descripcion,
                    oInscripcion.Catedras.Materia.NombreMateria,
                    "Quitar"
                });

            }

        }
        private void CargarCatedras()
        {

            cboCatedra.DataSource = servicio.TraerCatedras();
            cboCatedra.DisplayMember = "descripcion";
            cboCatedra.ValueMember = "id_catedra";

        }
        private void CargarEstudiante()
        {
            cboEstudiantes.DataSource = servicio.TraerEstudiante();
            cboEstudiantes.DisplayMember = "nombre";
            cboEstudiantes.ValueMember = "id_estudiante";

        }
        private void CargarEstado()
        {
            cboEstadoMateria.DataSource = servicio.TraerEstado();
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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvInscripcion.Rows.Count == 0)
            {
                MessageBox.Show("Debe ingresar al menos una inscripcion"
                    , "Control"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Exclamation);
                return;
            }
            GrabarCatedra();
        }

        private void GrabarCatedra()
        {
            oCatedra.Descripcion = cboCatedra.Text;
            oCatedra.Horario = cboHorarios.SelectedItem as Horarios;
            oCatedra.Materia = cboMaterias.SelectedItem as Materias;
            oCatedra.Docente = cboDocentes.SelectedItem as Docentes;
            oCatedra.Comision = cboComision.SelectedItem as Comisiones;
            oCatedra.Año = txtAño.Text;
            oCatedra.Cuatrimestre = txtCuatrimestre.Text;
            if (servicio.CrearCatedra(oCatedra))
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
