using SistemaAcademico.Entidades;
using SistemaAcademico.Presentacion;
using SistemaAcademico.Servicios;
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
    public partial class Form1 : Form
    {
        FabricaServicio fabrica = null;
        public Form1(FabricaServicio fabrica)
        {
            InitializeComponent();
            this.fabrica = fabrica;
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
            Presentacion.InstripcionMateria nuevo = new Presentacion.InstripcionMateria(fabrica);
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
    }
}
