using AutoMapper;
using SistemaAcademicoBackend.Entidades;
using SistemaAcademicoBackend.Servicios;
using SistemaAcademicoFrontend.Reporte;
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
    public partial class Form1 : Form
    {
        FabricaServicio fabrica = null;
        private readonly IMapper _mapper;
        public Form1(FabricaServicio fabrica, IMapper mapper)
        {
            InitializeComponent();
            this.fabrica = fabrica;
            _mapper = mapper;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void nuevoEstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InscripcionEstudiante nuevo = new InscripcionEstudiante(fabrica);
            nuevo.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void nuevaInscripcionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Presentacion.InstripcionMateria nuevo = new Presentacion.InstripcionMateria(fabrica,_mapper);
            nuevo.ShowDialog();
        }

        private void consultarMateriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarMateria nuevo=new ConsultarMateria(fabrica);
            nuevo.ShowDialog();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAcercaDe nuevo = new FormAcercaDe();
            nuevo.ShowDialog();
        }

        //private void InitializeComponent()
        //{
        //    this.SuspendLayout();
        //    // 
        //    // Form1
        //    // 
        //    this.ClientSize = new System.Drawing.Size(928, 588);
        //    this.Name = "Form1";
        //    this.Load += new System.EventHandler(this.Form1_Load_1);
        //    this.ResumeLayout(false);

        //}

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void calificacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRepoCalificaciones nuevo= new FormRepoCalificaciones();
            nuevo.ShowDialog();
        }

        private void consultarEstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarEstudiante nuevo = new ConsultarEstudiante(fabrica);
            nuevo.ShowDialog();
        }
    }
}
