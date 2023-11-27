using AutoMapper;
using Newtonsoft.Json;
using SistemaAcademicoBackend.Entidades;
using SistemaAcademicoBackend.EntidadesDto;
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
    public partial class InstripcionMateria : Form
    {
        IServicio servicio;
        Catedra nueva;
        CatedraDTO nuevaDTO;
        private readonly IMapper _mapper;


        public InstripcionMateria(FabricaServicio fabrica, IMapper mapper)
        {
            InitializeComponent();
            servicio = fabrica.CrearServicio();
            servicio = new Servicio();
            nueva= new Catedra();
            nuevaDTO= new CatedraDTO();
            _mapper = mapper;
        }

        private async void InstripcionMateria_Load(object sender, EventArgs e)
        {
            dtpFechaInscripcion.Value = DateTime.Today;
            await CargarCatedras();
            await cargarEstudiantes();
            await CargarEstado();
            await CargarHorario();
            await CargarMateria();
            await CargarDocente();
            await CargarComision();
            cboCatedra.SelectedIndex = -1;
            cboEstadoMateria.SelectedIndex = -1;
            cboEstudiantes.SelectedIndex = -1;
            cboHorario.SelectedIndex = -1;
            cboMateria.SelectedIndex = -1;
            cboDocente.SelectedIndex = -1;
            cboComision.SelectedIndex = -1;
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
            cboDocente.DataSource = lst;
            cboDocente.ValueMember = "id_docente";
            cboDocente.DisplayMember = "nombre";
        }

        private async Task CargarMateria()
        {
            string url = "https://localhost:7111/Materias";
            var data = await ClienteSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Materias>>(data);
            cboMateria.DataSource = lst;
            cboMateria.ValueMember = "idMateria";
            cboMateria.DisplayMember = "nombreMateria";
        }

        private async Task CargarHorario()
        {
            string url = "https://localhost:7111/Horarios";
            var data = await ClienteSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Horarios>>(data);
            cboHorario.DataSource = lst;
            cboHorario.ValueMember = "idHorarios";
            cboHorario.DisplayMember = "diaSemana";
        }

        private async Task CargarEstado()
        {
            string url = "https://localhost:7111/Estado";
            var data = await ClienteSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<EstadoMateria>>(data);
            cboEstadoMateria.DataSource = lst;
            cboEstadoMateria.ValueMember = "id_estado_materia";
            cboEstadoMateria.DisplayMember = "descripcion";
        }

        private async Task cargarEstudiantes()
        {
            string url = "https://localhost:7111/Estudiante";
            var data = await ClienteSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Estudiantes>>(data);
            cboEstudiantes.DataSource =lst;
            cboEstudiantes.ValueMember = "id_estudiante";
            cboEstudiantes.DisplayMember = "nombre";
        }

        private async Task CargarCatedras()
        {
            string url = "https://localhost:7111/Catedras";
            var data = await ClienteSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Catedra>>(data);
            cboCatedra.DataSource = lst;
            cboCatedra.ValueMember = "id_catedra";
            cboCatedra.DisplayMember = "Descripcion";
        }

        private void cboEstadoMateria_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            //    if (row.Cells["ColEstado"].Value.Equals(cboEstadoMateria.Text))
            //    {
            //        MessageBox.Show("El estado de materia ya esta puesto", "Control"
            //            , MessageBoxButtons.OK
            //            , MessageBoxIcon.Exclamation);
            //        return;
            //    }

            //}
            Estudiantes estudiante = (Estudiantes)cboEstudiantes.SelectedItem;

            Materias m=(Materias)cboMateria.SelectedItem;
            DateTime fecha = Convert.ToDateTime(dtpFechaInscripcion.Value);
            EstadoMateria estado = (EstadoMateria)cboEstadoMateria.SelectedItem;
            Catedra catedra=(Catedra)cboCatedra.SelectedItem;
            InscripcionMateria detalle = new InscripcionMateria(estudiante,fecha,estado,catedra);

            nueva.AgregarDetalle(detalle);
            dgvInscripcion.Rows.Add(new object[] { estudiante.Nombre, catedra.Descripcion, m.NombreMateria, "Quitar" });
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
            if (cboHorario.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un horario", "Control"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Exclamation);
                return false;
            }
            if (cboMateria.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una materia", "Control"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Exclamation);
                return false;
            }
            if (cboDocente.SelectedIndex == -1)
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
        

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvInscripcion.Rows.Count == 0)
            {
                MessageBox.Show("Debe ingresar al menos una inscripcion", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            await GrabarCatedra();
        }

        private async Task GrabarCatedra()
        {
            nuevaDTO.Descripcion = cboCatedra.Text;
            nuevaDTO.HorarioDTO = _mapper.Map<HorarioDTO>(cboHorario.SelectedItem);
            nuevaDTO.MateriaDTO = _mapper.Map<MateriasDTO>(cboMateria.SelectedItem);
            nuevaDTO.DocenteDTO = _mapper.Map<DocenteDTO>(cboDocente.SelectedItem);
            nuevaDTO.ComisionDTO = _mapper.Map<ComisionDTO>(cboComision.SelectedItem);
            nuevaDTO.Año = txtAño.Text;
            nuevaDTO.Cuatrimestre = txtCuatrimestre.Text;

            EstudiantesDTO estudiante = _mapper.Map<EstudiantesDTO>(cboEstudiantes.SelectedItem);
            DateTime fecha = Convert.ToDateTime(dtpFechaInscripcion.Value);
            EstadoMateriaDTO estado = _mapper.Map<EstadoMateriaDTO>(cboEstadoMateria.SelectedItem);
            InscripcionMateriaDTO detalle=new InscripcionMateriaDTO(estudiante,fecha,estado);

            nuevaDTO.AgregarDetalle(detalle);

            var bodyContent = JsonConvert.SerializeObject(nuevaDTO);
            string url = "https://localhost:7111/Inscripcion";
            var result = await ClienteSingleton.GetInstance().PostAsync(url, bodyContent);

            if (result.Equals("true"))
            {
                MessageBox.Show("Se registró con éxito la inscripcion", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {

                MessageBox.Show("No se pudo registrar la inscripcion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            //try
            //{
            //    if (result.Equals("true"))
            //    {
            //        MessageBox.Show("Se registró con éxito la inscripcion", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        this.Dispose();
            //    }
            //}
            //catch (Exception e)
            //{

            //    MessageBox.Show(e.Message);
            //}

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

        private void lblEstudiante_Click(object sender, EventArgs e)
        {

        }
    }
}
